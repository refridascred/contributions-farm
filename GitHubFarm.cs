using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

class GitHubFarm : Form
{
    Button btnConnect, btnStart, btnRefresh;
    Label lblAccount;
    ComboBox cmbRepo;
    TextBox txtLog;
    NumericUpDown numCount, numDays, numYearA, numYearB;
    ComboBox cmbMode;
    Label lblA, lblB;
    ProgressBar bar;
    CheckBox chkReal;
    // On: scan the repo, descriptive commit messages, small harmless code files. Off: old "contribution N" + farm.txt.
    bool realistic = true;
    // Date window: 0 = spread over the last N days, 1 = one year only (yearFrom), 2 = spread between yearFrom and yearTo.
    int dateMode = 0, yearFrom, yearTo;
    // Share of the commits that change a file; the rest are message-only commits.
    const double FileShare = 0.95;
    static readonly Encoding Utf8 = new UTF8Encoding(false);
    ToolTip tip = new ToolTip();

    string login, token, email;
    const string NEW_REPO = "+ Create new repo...";
    Dictionary<string, string> defaultBranch = new Dictionary<string, string>();
    static JavaScriptSerializer json = new JavaScriptSerializer();

    [STAThread]
    static int Main(string[] args)
    {
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.2
        if (args.Length == 2 && args[0] == "--selftest") return SelfTest(args[1]);
        Application.EnableVisualStyles();
        Application.Run(new GitHubFarm());
        return 0;
    }

    // Runs everything offline against a fake local "GitHub" and writes results to a file.
    static int SelfTest(string outFile)
    {
        var log = new TestLog(outFile);
        try
        {
            // 1. Parse a real-shaped /user/repos response.
            string sample = "[{\"name\":\"alpha\",\"default_branch\":\"main\",\"private\":false},{\"name\":\"beta\",\"default_branch\":\"master\"},{\"name\":\"empty\",\"default_branch\":null}]";
            var names = new List<string>(); var br = new Dictionary<string, string>();
            int n = ParseRepos(json.DeserializeObject(sample), names, br);
            if (n != 3 || br["beta"] != "master" || br["empty"] != "main") throw new Exception("repo parsing wrong");
            log.AppendLine("PASS repo list parsing: " + string.Join(", ", names.ToArray()));
            var me = (Dictionary<string, object>)json.DeserializeObject("{\"login\":\"x\",\"id\":123}");
            log.AppendLine("PASS user parsing: " + me["id"] + "+" + me["login"]);

            // 2. Farm into an empty bare repo and into one with existing history on 'master'.
            var f = new GitHubFarm();
            f.login = "selftest"; f.email = "1+selftest@users.noreply.github.com"; f.token = "dummytoken";
            string tmp = Path.Combine(Path.GetTempPath(), "ghfarm_selftest");
            if (Directory.Exists(tmp)) ForceDelete(tmp);
            Directory.CreateDirectory(tmp);

            string bare = Path.Combine(tmp, "remote_empty.git");
            f.RunProc("git", "init -q --bare \"" + bare + "\"", null, null, null);
            f.RunProc("git", "config core.logAllRefUpdates always", null, bare, null);
            var sw = Stopwatch.StartNew(); f.Farm("st_empty", "main", 5000, 365, bare); log.AppendLine("5000 commits took " + sw.Elapsed.TotalSeconds.ToString("0.0") + "s");
            string pushes = f.RunProc("git", "reflog show --format=%H refs/heads/main", null, bare, null);
            int pushCount = pushes.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (pushCount != 5) throw new Exception("expected 5 uploads of 1000, got " + pushCount);
            log.AppendLine("PASS 5000 commits uploaded as 5 batches of 1000");
            string subjOut = f.RunProc("git", "log main --format=%s", null, bare, null);
            string[] subjects = subjOut.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var distinctSubjects = new HashSet<string>(subjects);
            foreach (string sj in subjects)
                if (sj.ToLowerInvariant().StartsWith("contribution")) throw new Exception("generic commit message found: " + sj);
            if (distinctSubjects.Count < subjects.Length / 2)
                throw new Exception("commit messages repeat too much: " + distinctSubjects.Count + " distinct of " + subjects.Length);
            string tree = f.RunProc("git", "ls-tree -r --name-only main", null, bare, null);
            if (tree.Contains("farm.txt")) throw new Exception("realistic mode must not write farm.txt");
            if (!tree.Contains("README.md")) throw new Exception("empty repo should get a README.md");
            int touching = 0; bool anyFile = false, inCommit = false;
            foreach (string raw in f.RunProc("git", "log main --name-only --format=@@", null, bare, null).Split('\n'))
            {
                string ln = raw.Trim();
                if (ln == "@@") { if (inCommit && anyFile) touching++; inCommit = true; anyFile = false; }
                else if (ln.Length > 0) anyFile = true;
            }
            if (inCommit && anyFile) touching++;
            if (touching < subjects.Length * 90 / 100) throw new Exception("only " + touching + " of " + subjects.Length + " commits change a file");
            log.AppendLine("PASS file changes: " + touching + " of " + subjects.Length + " commits change a file (" + (touching * 100 / subjects.Length) + "%)");
            log.AppendLine("PASS realistic messages: " + distinctSubjects.Count + " distinct of " + subjects.Length + ", newest: " + subjects[0]);
            log.AppendLine("PASS generated files: " + tree.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length + " files in the tree");
            var sw2 = Stopwatch.StartNew(); f.Farm("st_big", "main", 50000, 365, bare);
            log.AppendLine("50000 commits (create + 50 uploads) took " + sw2.Elapsed.TotalSeconds.ToString("0.0") + "s");
            if (Directory.Exists(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GitHubFarm"), "selftest_st_big")))
                throw new Exception("work folder (with token) was not deleted");
            log.AppendLine("PASS work folder deleted after upload");
            f.Farm("st_empty", "main", 10, 30, bare); // run again: must stack
            string c = f.RunProc("git", "rev-list --count main", null, bare, null).Trim();
            if (c != "55010") throw new Exception("expected 55010 commits, got " + c);
            log.AppendLine("PASS runs stack: 55010 commits total");

            string dates = f.RunProc("git", "log main --format=%ad --date=short", null, bare, null);
            var distinct = new HashSet<string>(dates.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            if (distinct.Count < 5) throw new Exception("dates not spread: " + distinct.Count);
            log.AppendLine("PASS dates spread over " + distinct.Count + " different days");
            string em = f.RunProc("git", "log -1 main --format=%ae", null, bare, null).Trim();
            if (em != f.email) throw new Exception("wrong email " + em);
            log.AppendLine("PASS author email " + em);

            string bare2 = Path.Combine(tmp, "remote_master.git");
            string seed = Path.Combine(tmp, "seed");
            f.RunProc("git", "init -q -b master \"" + seed + "\"", null, null, null);
            File.WriteAllText(Path.Combine(seed, "README.md"), "hi");
            f.RunProc("git", "add .", null, seed, null);
            f.RunProc("git", "-c user.name=a -c user.email=a@a commit -q -m init", null, seed, null);
            f.RunProc("git", "clone -q --bare \"" + seed + "\" \"" + bare2 + "\"", null, null, null);
            f.Farm("st_master", "master", 15, 365, bare2);
            c = f.RunProc("git", "rev-list --count master", null, bare2, null).Trim();
            if (c != "16") throw new Exception("expected 16 commits on master, got " + c);
            log.AppendLine("PASS existing repo on 'master': history kept, 15 added");
            if (f.RunProc("git", "show master:README.md", null, bare2, null).Trim() != "hi") throw new Exception("existing README.md was modified");
            log.AppendLine("PASS existing files left untouched");

            f.realistic = false;
            f.Farm("st_plain", "master", 5, 30, bare2);
            string lastMsg = f.RunProc("git", "log -1 master --format=%s", null, bare2, null).Trim();
            if (lastMsg != "contribution 5") throw new Exception("switch off should give the old messages, got: " + lastMsg);
            f.realistic = true;
            log.AppendLine("PASS realistic mode switched off: old behaviour kept");

            // Date window: one year only, then a spread between two years.
            f.dateMode = 1; f.yearFrom = 2019; f.yearTo = 2019;
            f.Farm("st_year", "master", 20, 365, bare2);
            string[] yrs = f.RunProc("git", "log -20 master --format=%ad --date=format:%Y", null, bare2, null).Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (yrs.Length != 20) throw new Exception("expected 20 commits in the year test, got " + yrs.Length);
            foreach (string y in yrs) if (y.Trim() != "2019") throw new Exception("one-year mode wrote a commit dated " + y);
            log.AppendLine("PASS one year only: 20 commits, all dated 2019");
            f.dateMode = 2; f.yearFrom = 2015; f.yearTo = 2016;
            f.Farm("st_years", "master", 40, 365, bare2);
            var yset = new HashSet<string>();
            foreach (string y in f.RunProc("git", "log -40 master --format=%ad --date=format:%Y", null, bare2, null).Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)) yset.Add(y.Trim());
            if (!yset.Contains("2015") || !yset.Contains("2016") || yset.Count != 2) throw new Exception("two-year mode gave years: " + string.Join(",", new List<string>(yset).ToArray()));
            log.AppendLine("PASS spread between 2015 and 2016: both years used, nothing else");
            f.dateMode = 0;

            ForceDelete(tmp);
            log.AppendLine("ALL TESTS PASSED");
            File.WriteAllText(outFile, log.ToString());
            return 0;
        }
        catch (Exception ex)
        {
            log.AppendLine("FAIL: " + ex);
            File.WriteAllText(outFile, log.ToString());
            return 1;
        }
    }


    GitHubFarm()
    {
        Text = "GitHub Farm - made by Scred";
        Width = 560; Height = 565;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Font = new Font("Segoe UI", 9.5f);

        btnConnect = new Button { Text = "Connect GitHub account", Left = 15, Top = 15, Width = 200, Height = 32 };
        btnConnect.Click += delegate { Connect(); };
        Controls.Add(btnConnect);
        lblAccount = new Label { Text = "Not connected", Left = 225, Top = 22, Width = 300 };
        Controls.Add(lblAccount);

        Controls.Add(new Label { Text = "Repository:", Left = 15, Top = 63, Width = 100 });
        cmbRepo = new ComboBox { Left = 120, Top = 60, Width = 310, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
        Controls.Add(cmbRepo);
        btnRefresh = new Button { Text = "Refresh", Left = 440, Top = 59, Width = 85, Enabled = false };
        btnRefresh.Click += delegate { LoadRepos(null); };
        Controls.Add(btnRefresh);

        Controls.Add(new Label { Text = "Contributions:", Left = 15, Top = 103, Width = 100 });
        numCount = new NumericUpDown { Left = 120, Top = 100, Width = 100, Minimum = 1, Maximum = 1000000, Value = 1000, ThousandsSeparator = true };
        Controls.Add(numCount);

        Controls.Add(new Label { Text = "Dates:", Left = 240, Top = 103, Width = 50 });
        cmbMode = new ComboBox { Left = 295, Top = 100, Width = 230, DropDownStyle = ComboBoxStyle.DropDownList };
        cmbMode.Items.AddRange(new object[] { "Spread over the last N days", "One year only", "Spread between two years" });
        cmbMode.SelectedIndex = 0;
        tip.SetToolTip(cmbMode, "Spread over the last N days: random dates from N days ago until now.\nOne year only: all commits get dates inside that one calendar year.\nSpread between two years: random dates from 1 Jan of the first year to 31 Dec of the second (never later than now).");
        Controls.Add(cmbMode);

        int thisYear = DateTime.Now.Year;
        lblA = new Label { Text = "Last N days:", Left = 15, Top = 138, Width = 100 };
        Controls.Add(lblA);
        numDays = new NumericUpDown { Left = 120, Top = 135, Width = 100, Minimum = 1, Maximum = 3650, Value = 365 };
        Controls.Add(numDays);
        numYearA = new NumericUpDown { Left = 120, Top = 135, Width = 100, Minimum = 2008, Maximum = thisYear, Value = thisYear > 2008 ? thisYear - 1 : thisYear, Visible = false };
        Controls.Add(numYearA);
        lblB = new Label { Text = "To year:", Left = 240, Top = 138, Width = 100, Visible = false };
        Controls.Add(lblB);
        numYearB = new NumericUpDown { Left = 345, Top = 135, Width = 100, Minimum = 2008, Maximum = thisYear, Value = thisYear, Visible = false };
        Controls.Add(numYearB);
        cmbMode.SelectedIndexChanged += delegate { ApplyMode(); };

        chkReal = new CheckBox { Text = "Realistic commits (names from the repo + small harmless code files)", Left = 15, Top = 173, Width = 510, Height = 24, Checked = true };
        tip.SetToolTip(chkReal, "ON: the repo is scanned and every commit gets a normal-looking message; about 95% of the commits also change a different generated file (code, config, SQL, notes ...) in the repo's main language.\nOFF: plain \"contribution N\" commits that only change farm.txt.");
        Controls.Add(chkReal);

        btnStart = new Button { Text = "START", Left = 15, Top = 203, Width = 510, Height = 36, Enabled = false };
        btnStart.Click += delegate { Start(); };
        Controls.Add(btnStart);

        bar = new ProgressBar { Left = 15, Top = 248, Width = 510, Height = 18 };
        Controls.Add(bar);

        txtLog = new TextBox { Left = 15, Top = 275, Width = 510, Height = 227, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };
        Controls.Add(txtLog);
    }

    // ---------- UI helpers ----------
    void Ui(Action a) { if (InvokeRequired) BeginInvoke(a); else a(); }
    void Log(string s) { Ui(delegate { txtLog.AppendText(s + Environment.NewLine); }); }
    void Bg(Action a)
    {
        new Thread(delegate ()
        {
            try { a(); }
            catch (Exception ex) { Log("ERROR: " + (token != null ? ex.Message.Replace(token, "***") : ex.Message)); Ui(delegate { SetBusy(false); }); }
        }) { IsBackground = true }.Start();
    }
    void ApplyMode()
    {
        int m = cmbMode.SelectedIndex;
        numDays.Visible = m == 0;
        numYearA.Visible = m != 0;
        lblB.Visible = numYearB.Visible = m == 2;
        lblA.Text = m == 0 ? "Last N days:" : (m == 1 ? "Year:" : "From year:");
    }

    void SetBusy(bool busy)
    {
        btnConnect.Enabled = !busy;
        chkReal.Enabled = !busy;
        cmbMode.Enabled = !busy; numDays.Enabled = !busy; numYearA.Enabled = !busy; numYearB.Enabled = !busy;
        bool ok = !busy && token != null;
        btnStart.Enabled = ok; cmbRepo.Enabled = ok; btnRefresh.Enabled = ok;
    }

    // ---------- Sign in (uses Git Credential Manager's browser login) ----------
    void Connect()
    {
        SetBusy(true);
        Log("Opening GitHub sign-in... (choose 'Sign in with your browser' if asked)");
        Bg(delegate
        {
            string cred = RunProc("git", "credential fill", "protocol=https\nhost=github.com\n\n", null, null);
            string user = null, pass = null;
            foreach (var line in cred.Split('\n'))
            {
                var l = line.Trim();
                if (l.StartsWith("username=")) user = l.Substring(9);
                if (l.StartsWith("password=")) pass = l.Substring(9);
            }
            if (pass == null) throw new Exception("Sign-in was cancelled.");
            token = pass;

            var me = (Dictionary<string, object>)Api("GET", "/user", null);
            login = (string)me["login"];
            email = me["id"] + "+" + login + "@users.noreply.github.com";
            // Save the credential so you stay connected next time.
            RunProc("git", "credential approve", "protocol=https\nhost=github.com\nusername=" + (user ?? login) + "\npassword=" + token + "\n\n", null, null);

            Ui(delegate { lblAccount.Text = "Connected as " + login; });
            Log("Connected as " + login);
            LoadRepos(null);
        });
    }

    void LoadRepos(string select)
    {
        Ui(delegate { SetBusy(true); });
        Bg(delegate
        {
            var names = new List<string>();
            defaultBranch.Clear();
            for (int page = 1; page < 20; page++)
            {
                int got = ParseRepos(Api("GET", "/user/repos?affiliation=owner&per_page=100&sort=updated&page=" + page, null), names, defaultBranch);
                if (got < 100) break;
            }
            Ui(delegate
            {
                cmbRepo.Items.Clear();
                cmbRepo.Items.Add(NEW_REPO);
                foreach (var n in names) cmbRepo.Items.Add(n);
                int idx = select != null ? cmbRepo.Items.IndexOf(select) : -1;
                cmbRepo.SelectedIndex = idx >= 0 ? idx : (names.Count > 0 ? 1 : 0);
                SetBusy(false);
            });
            Log("Loaded " + names.Count + " repos.");
        });
    }

    static int ParseRepos(object apiResult, List<string> names, Dictionary<string, string> branches)
    {
        var arr = (IList)apiResult; // JavaScriptSerializer returns object[] for JSON arrays
        foreach (object o in arr)
        {
            var r = (IDictionary<string, object>)o;
            string n = (string)r["name"];
            names.Add(n);
            object b;
            branches[n] = r.TryGetValue("default_branch", out b) && b is string ? (string)b : "main";
        }
        return arr.Count;
    }

    // ---------- Farming ----------
    void Start()
    {
        string repo = (string)cmbRepo.SelectedItem;
        if (repo == NEW_REPO)
        {
            repo = Prompt("Name for the new (private) repo:", "contributions");
            if (string.IsNullOrEmpty(repo)) return;
        }
        int count = (int)numCount.Value, days = (int)numDays.Value;
        realistic = chkReal.Checked;
        dateMode = cmbMode.SelectedIndex;
        yearFrom = (int)numYearA.Value;
        yearTo = dateMode == 2 ? (int)numYearB.Value : yearFrom;
        if (yearFrom > yearTo) { int t = yearFrom; yearFrom = yearTo; yearTo = t; }
        SetBusy(true);
        txtLog.Clear();
        string r = repo;
        Bg(delegate
        {
            if (!defaultBranch.ContainsKey(r))
            {
                Log("Creating repo " + r + "...");
                var body = new Dictionary<string, object>();
                body["name"] = r; body["private"] = true;
                var created = (Dictionary<string, object>)Api("POST", "/user/repos", body);
                r = (string)created["name"];
                defaultBranch[r] = "main";
            }
            Farm(r, defaultBranch[r], count, days);
            LoadRepos(r);
        });
    }

    void Farm(string repo, string branch, int count, int days)
    {
        Farm(repo, branch, count, days, "https://" + login + ":" + token + "@github.com/" + login + "/" + repo + ".git");
    }

    // Random dates for the commits, sorted oldest first. dateMode 0: last N days; 1 and 2: inside the chosen calendar years.
    List<DateTime> MakeDates(Random rnd, int count, int days)
    {
        DateTime now = DateTime.Now, winStart, winEnd;
        if (dateMode == 0) { winEnd = now; winStart = now.AddDays(-days); }
        else
        {
            // Commits are written in UTC, so the calendar years are UTC years too.
            winStart = new DateTime(yearFrom, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            winEnd = new DateTime(yearTo, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            if (winEnd > DateTime.UtcNow) winEnd = DateTime.UtcNow;
            if (winStart >= winEnd) throw new Exception("The chosen year has not started yet, pick an earlier year.");
        }
        double span = (winEnd - winStart).TotalSeconds;
        var dates = new List<DateTime>(count);
        for (int i = 0; i < count; i++) dates.Add(winStart.AddSeconds(rnd.NextDouble() * span));
        dates.Sort();
        Log("Dates: " + winStart.ToString("yyyy-MM-dd") + " to " + winEnd.ToString("yyyy-MM-dd"));
        return dates;
    }

    void Farm(string repo, string branch, int count, int days, string remote)
    {
        var rnd = new Random();
        List<DateTime> dates = MakeDates(rnd, count, days);   // validates the chosen years before anything is downloaded
        string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GitHubFarm");
        string dir = Path.Combine(root, login + "_" + repo);
        if (Directory.Exists(dir)) ForceDelete(dir);
        Directory.CreateDirectory(root);

        Log("Downloading " + repo + "...");
        Git(root, "clone \"" + remote + "\" \"" + dir + "\"", null);
        Git(dir, "config user.name \"" + login + "\"", null);
        Git(dir, "config user.email \"" + email + "\"", null);
        try { Git(dir, "checkout -q " + branch, null); } catch { Git(dir, "checkout -q -B " + branch, null); }

        Log("Creating " + count + " contributions...");
        // Stream all commits straight into git fast-import (no big buffer in memory).
        string parent = null;
        try { parent = RunProc("git", "rev-parse --verify -q HEAD", null, dir, null).Trim(); } catch { }
        ContentGen gen = null;
        if (realistic)
        {
            RepoProfile prof = ScanRepo(dir, repo, parent);
            gen = new ContentGen(prof, rnd, FileShare);
            Log("About " + (int)Math.Round(FileShare * 100) + "% of the commits will change a file, the rest are message-only.");
            if (count > 100000) Log("Big run: every file-changing commit stores a new file version, so this takes longer and needs more disk space than a message-only run.");
            Log("Scanned repo: " + prof.Describe());
        }
        var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        string head = "commit refs/heads/" + branch + "\n";
        string whoPrefix = login + " <" + email + "> ";
        RunProcStream("git", "fast-import --quiet --force --done", dir, delegate (Stream s)
        {
            var w = new StreamWriter(s, new UTF8Encoding(false), 1 << 20);
            w.NewLine = "\n";
            for (int i = 0; i < count; i++)
            {
                long unix = (long)(dates[i].ToUniversalTime() - epoch).TotalSeconds;
                string who = whoPrefix + unix + " +0000\n";
                string msg;
                List<string[]> files;
                if (gen != null)
                {
                    CommitPlan cp = gen.Next();
                    msg = cp.Message;
                    files = cp.Files;
                }
                else
                {
                    msg = "contribution " + (i + 1);
                    files = new List<string[]>();
                    files.Add(new string[] { "farm.txt", dates[i].ToString("yyyy-MM-dd HH:mm:ss") + "\n" });
                }
                w.Write(head);
                w.Write("author "); w.Write(who);
                w.Write("committer "); w.Write(who);
                w.Write("data " + Utf8.GetByteCount(msg) + "\n" + msg + "\n");
                if (i == 0 && !string.IsNullOrEmpty(parent)) w.Write("from " + parent + "\n");
                foreach (string[] f in files)
                    w.Write("M 100644 inline " + f[0] + "\ndata " + Utf8.GetByteCount(f[1]) + "\n" + f[1] + "\n");
                if ((i + 1) % 10000 == 0)
                {
                    int v = i + 1;
                    Ui(delegate { bar.Maximum = count * 2; bar.Value = v; });
                    if (v % 100000 == 0) Log("  " + v + " / " + count + " created");
                }
            }
            w.Write("done\n");
            w.Flush();
        });
        Log("  " + count + " / " + count + " created");

        // Upload in batches so huge amounts don't time out on GitHub.
        Log("Uploading to GitHub...");
        string range = string.IsNullOrEmpty(parent) ? "refs/heads/" + branch : parent + "..refs/heads/" + branch;
        string[] shas = RunProc("git", "rev-list --reverse " + range, null, dir, null)
            .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        // GitHub only counts ~1000 commits per push toward the graph, so push 1000 at a time.
        const int BATCH = 1000;
        for (int k = 0; k < shas.Length; k += BATCH)
        {
            int end = Math.Min(k + BATCH, shas.Length);
            Git(dir, "push -q \"" + remote + "\" " + shas[end - 1].Trim() + ":refs/heads/" + branch, null);
            Ui(delegate { bar.Maximum = count * 2; bar.Value = Math.Min(count * 2, count + end); });
            if ((end / BATCH) % 10 == 0 || end == shas.Length) Log("  uploaded " + end + " / " + shas.Length);
        }
        try { ForceDelete(dir); } catch { } // don't leave the login token on disk
        Log("DONE! Your graph may take a few minutes to update.");
    }

    // Reads the cloned repo (file list + README) so commits can match what the repo is about.
    RepoProfile ScanRepo(string dir, string repo, string parent)
    {
        string[] paths = new string[0];
        string readme = "";
        if (!string.IsNullOrEmpty(parent))
        {
            try { paths = RunProc("git", "ls-files -z", null, dir, null).Split(new[] { '\0' }, StringSplitOptions.RemoveEmptyEntries); } catch { }
            foreach (string pth in paths)
            {
                if (pth.IndexOf('/') >= 0 || !pth.StartsWith("readme", StringComparison.OrdinalIgnoreCase)) continue;
                try
                {
                    using (var sr = new StreamReader(Path.Combine(dir, pth)))
                    {
                        char[] buf = new char[2000];
                        int n = sr.Read(buf, 0, buf.Length);
                        readme = new string(buf, 0, n);
                    }
                }
                catch { }
                break;
            }
        }
        return RepoScanner.Scan(paths, readme, repo, string.IsNullOrEmpty(parent));
    }

    // ---------- Plumbing ----------
    object Api(string method, string path, object body)
    {
        var req = (HttpWebRequest)WebRequest.Create("https://api.github.com" + path);
        req.Method = method;
        req.UserAgent = "GitHubFarm";
        req.Accept = "application/vnd.github+json";
        req.Headers["Authorization"] = "Bearer " + token;
        if (body != null)
        {
            byte[] b = Encoding.UTF8.GetBytes(json.Serialize(body));
            req.ContentType = "application/json";
            using (var s = req.GetRequestStream()) s.Write(b, 0, b.Length);
        }
        try
        {
            using (var resp = req.GetResponse())
            using (var sr = new StreamReader(resp.GetResponseStream()))
                return json.DeserializeObject(sr.ReadToEnd());
        }
        catch (WebException ex)
        {
            string msg = ex.Message;
            if (ex.Response != null) using (var sr = new StreamReader(ex.Response.GetResponseStream())) msg += " " + sr.ReadToEnd();
            throw new Exception("GitHub API " + path + ": " + msg);
        }
    }

    void Git(string cwd, string args, Dictionary<string, string> env)
    {
        RunProc("git", args, null, cwd, env);
    }

    void RunProcStream(string exe, string args, string cwd, Action<Stream> writer)
    {
        var psi = new ProcessStartInfo(exe, args)
        {
            UseShellExecute = false, CreateNoWindow = true, WorkingDirectory = cwd,
            RedirectStandardOutput = true, RedirectStandardError = true, RedirectStandardInput = true
        };
        var p = Process.Start(psi);
        var outTask = p.StandardOutput.ReadToEndAsync();
        var errTask = p.StandardError.ReadToEndAsync();
        Exception writeErr = null;
        try { writer(p.StandardInput.BaseStream); } catch (Exception ex) { writeErr = ex; }
        try { p.StandardInput.Close(); } catch { }
        string outp = outTask.Result, err = errTask.Result;
        p.WaitForExit();
        if (p.ExitCode != 0 || writeErr != null)
            throw new Exception(exe + " " + args + "\n" + err + outp + (writeErr != null ? writeErr.Message : ""));
    }

    string RunProc(string exe, string args, string stdin, string cwd, Dictionary<string, string> env)
    {
        var psi = new ProcessStartInfo(exe, args)
        {
            UseShellExecute = false, CreateNoWindow = true,
            RedirectStandardOutput = true, RedirectStandardError = true, RedirectStandardInput = stdin != null
        };
        if (cwd != null) psi.WorkingDirectory = cwd;
        if (env != null) foreach (var kv in env) psi.EnvironmentVariables[kv.Key] = kv.Value;
        Process p;
        try { p = Process.Start(psi); }
        catch { throw new Exception("Git is not installed. Get it from git-scm.com."); }
        var outTask = p.StandardOutput.ReadToEndAsync();
        var errTask = p.StandardError.ReadToEndAsync();
        if (stdin != null)
        {
            byte[] b = new UTF8Encoding(false).GetBytes(stdin);
            p.StandardInput.BaseStream.Write(b, 0, b.Length);
            p.StandardInput.Close();
        }
        string outp = outTask.Result;
        string err = errTask.Result;
        p.WaitForExit();
        if (p.ExitCode != 0) throw new Exception(exe + " " + args + "\n" + err + outp);
        return outp;
    }

    string Prompt(string text, string def)
    {
        var f = new Form { Text = "GitHub Farm", Width = 360, Height = 150, FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent, MaximizeBox = false, MinimizeBox = false };
        f.Controls.Add(new Label { Text = text, Left = 12, Top = 12, Width = 320 });
        var tb = new TextBox { Text = def, Left = 12, Top = 36, Width = 320 };
        var ok = new Button { Text = "OK", Left = 252, Top = 70, Width = 80, DialogResult = DialogResult.OK };
        f.Controls.Add(tb); f.Controls.Add(ok); f.AcceptButton = ok;
        return f.ShowDialog(this) == DialogResult.OK ? tb.Text.Trim() : null;
    }

    static void ForceDelete(string path)
    {
        foreach (var f in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            File.SetAttributes(f, FileAttributes.Normal);
        Directory.Delete(path, true);
    }
}

// =====================================================================
//  Realistic commit content: scans the repo and produces descriptive
//  commit messages plus small, harmless code files that match it.
//  Generated code is pure functions only: no I/O, no network, no process
//  or reflection calls, and nothing in it is ever executed by this app.
// =====================================================================

enum Lang { Py, Js, Ts, Cs, Java, Go, Rust, Cpp }

class TestLog
{
    readonly StringBuilder sb = new StringBuilder();
    readonly string path;
    public TestLog(string path) { this.path = path; Flush(); }
    public void AppendLine(string s) { sb.AppendLine(s); Flush(); }
    void Flush() { try { File.WriteAllText(path, sb.ToString() + "(running ...)" + Environment.NewLine); } catch { } }
    public override string ToString() { return sb.ToString(); }
}


class CommitPlan
{
    public string Message;
    public List<string[]> Files = new List<string[]>();
    public void Add(string path, string content) { Files.Add(new string[] { path, content }); }
}

class GenFile
{
    public string Path, Header = "", Footer = "", Sep = "\n\n", Slug, Title;
    public int Max;
    public List<Chunk> Items = new List<Chunk>();
    public HashSet<string> Names = new HashSet<string>();
    public bool Full { get { return Items.Count >= Max; } }
    public void Add(Chunk c) { Items.Add(c); foreach (string s in c.Syms) Names.Add(s); }
    public void Insert(int i, Chunk c) { Items.Insert(i, c); foreach (string s in c.Syms) Names.Add(s); }
    public Chunk RemoveAt(int i)
    {
        Chunk c = Items[i]; Items.RemoveAt(i);
        foreach (string s in c.Syms) Names.Remove(s);
        return c;
    }
    public string Content()
    {
        var codes = new List<string>();
        foreach (Chunk c in Items) codes.Add(c.Code);
        return Header + string.Join(Sep, codes.ToArray()) + "\n" + Footer;
    }
}

class RepoProfile
{
    public Lang Lang = Lang.Py;
    public string SrcDir = "src";
    public string Slug = "", Title = "Project";
    public string JavaRoot;
    public bool Empty;
    public List<string> Nouns = new List<string>();
    public HashSet<string> Paths = new HashSet<string>();
    public HashSet<string> Dirs = new HashSet<string>();
    public HashSet<string> Stems = new HashSet<string>();

    public string Describe()
    {
        var top = new List<string>();
        for (int i = 0; i < Nouns.Count && i < 6; i++) top.Add(Nouns[i]);
        return Nm.LangName(Lang) + ", new files go in " + SrcDir + "/, topics: " + string.Join(", ", top.ToArray());
    }
}

static class Vocab
{
    public static readonly HashSet<string> Reserved = new HashSet<string>((
        "and as assert async await break class const continue def del elif else except finally for from global if import in is lambda none " +
        "nonlocal not or pass raise return try while with yield abstract boolean byte case catch char default do double enum extends final " +
        "float goto implements instanceof int interface long native new package private protected public short static strictfp super switch " +
        "synchronized this throw throws transient void volatile null true false var let function typeof delete export debugger arguments eval " +
        "namespace module declare readonly keyof type any never unknown symbol object string number math system thread runtime character " +
        "integer console convert random array list map set date time task action func struct union typedef template typename operator " +
        "virtual explicit friend inline mutable register signed unsigned sizeof using extern select defer chan range fallthrough iota error " +
        "main common utilities utils helpers core internal std crate self mod trait impl match loop move ref mut dyn unsafe where use pub box " +
        "include define lib test tests").Split(' '));

    public static readonly HashSet<string> Stop = new HashSet<string>((
        "index main test tests spec specs readme license licence config configs package packages setup lock init app apps src lib libs dist " +
        "build node modules bin obj json yaml yml toml txt docs doc assets static public vendor git github util utils helper helpers common " +
        "core misc data temp tmp example examples sample samples demo scripts script template templates resources res images image img icons " +
        "icon styles style css html md gitignore editorconfig properties settings program version versions changelog contributing makefile " +
        "dockerfile target release debug output outputs cache").Split(' '));

    public static readonly HashSet<string> Filler = new HashSet<string>((
        "which there their these about would should could using please install download contains first other while where after before every " +
        "thing things those because still being under again also into only your yours with from this that have will when then than them they " +
        "what just like make made more most much each used uses very need needs open click press wait done turn adds adding source build " +
        "running steps notes note usage example examples windows linux macos github repo repository project").Split(' '));

    public static readonly string[] Defaults = (
        "account batch buffer cache channel cluster command context counter session record report profile queue metric token schema route " +
        "filter payload layout stream window order invoice catalog ticket booking cursor digest editor entry folder gateway handler inbox " +
        "journal ledger locale manifest message module notice package parcel plan policy preset quota region sample sensor shard signal " +
        "snapshot socket tracker vault widget worker").Split(' ');
}

static class Nm
{
    public static string Cap(string s) { return s.Length == 0 ? s : char.ToUpperInvariant(s[0]) + s.Substring(1); }

    public static string Pascal(IEnumerable<string> w)
    {
        var sb = new StringBuilder();
        foreach (string s in w) sb.Append(Cap(s));
        return sb.ToString();
    }

    public static string Camel(IEnumerable<string> w)
    {
        string p = Pascal(w);
        return p.Length == 0 ? p : char.ToLowerInvariant(p[0]) + p.Substring(1);
    }

    public static string Combine(string a, string b) { return a.Length == 0 ? b : a + "/" + b; }

    public static List<string> Words(string s)
    {
        var r = new List<string>();
        if (s == null) return r;
        foreach (Match m in Regex.Matches(s, "[A-Z]?[a-z]+")) r.Add(m.Value.ToLowerInvariant());
        return r;
    }

    public static string FnName(Lang l, IEnumerable<string> w)
    {
        switch (l)
        {
            case Lang.Py: case Lang.Rust: return string.Join("_", w);
            case Lang.Js: case Lang.Ts: case Lang.Java: case Lang.Cpp: return Camel(w);
            default: return Pascal(w);
        }
    }

    public static string StemFor(Lang l, IEnumerable<string> w)
    {
        switch (l)
        {
            case Lang.Py: case Lang.Rust: case Lang.Cpp: return string.Join("_", w);
            case Lang.Js: case Lang.Ts: return string.Join("-", w);
            case Lang.Go: return string.Join("", w);
            default: return Pascal(w);
        }
    }

    public static string Ext(Lang l)
    {
        switch (l)
        {
            case Lang.Py: return ".py";
            case Lang.Js: return ".js";
            case Lang.Ts: return ".ts";
            case Lang.Cs: return ".cs";
            case Lang.Java: return ".java";
            case Lang.Go: return ".go";
            case Lang.Rust: return ".rs";
            default: return ".hpp";
        }
    }

    public static string LangName(Lang l)
    {
        switch (l)
        {
            case Lang.Py: return "Python";
            case Lang.Js: return "JavaScript";
            case Lang.Ts: return "TypeScript";
            case Lang.Cs: return "C#";
            case Lang.Java: return "Java";
            case Lang.Go: return "Go";
            case Lang.Rust: return "Rust";
            default: return "C/C++";
        }
    }

    // Go wants tabs; templates are written with 4-space indentation.
    public static string Tabs(string code)
    {
        string[] lines = code.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            int n = 0;
            while (n < lines[i].Length && lines[i][n] == ' ') n++;
            int t = n / 4;
            lines[i] = new string('\t', t) + lines[i].Substring(t * 4);
        }
        return string.Join("\n", lines);
    }

    public static string Indent(string code, string prefix)
    {
        if (prefix.Length == 0) return code;
        string[] lines = code.Split('\n');
        for (int i = 0; i < lines.Length; i++)
            if (lines[i].Length > 0) lines[i] = prefix + lines[i];
        return string.Join("\n", lines);
    }

    // Puts a doc comment in the style of the language in front of a piece of code.
    public static string DocComment(Lang lang, string name, string desc, string code)
    {
        string d = Cap(desc) + ".";
        switch (lang)
        {
            case Lang.Py:
            {
                if (!(code.StartsWith("def ") || code.StartsWith("class "))) return "# " + d + "\n" + code;
                int nl = code.IndexOf('\n');
                return code.Substring(0, nl + 1) + "    \"\"\"" + d + "\"\"\"\n" + code.Substring(nl + 1);
            }
            case Lang.Js: case Lang.Ts: case Lang.Java:
                return "/** " + d + " */\n" + code;
            case Lang.Cs:
                return "/// <summary>" + d + "</summary>\n" + code;
            case Lang.Go:
                return "// " + name + ": " + d + "\n" + code;
            case Lang.Rust:
                return "/// " + d + "\n" + code;
            default:
                return "// " + d + "\n" + code;
        }
    }
}

// ---------------------------------------------------------------------
//  Random program generator. Every function is built from scratch as a
//  small typed tree (no templates) and rendered into the repo's language.
//  Pure arithmetic and control flow only: no I/O, nothing is executed.
// ---------------------------------------------------------------------

enum VT { I, N, B, A, X }   // integer, number (double), bool, integer array, loop index
enum EK { Lit, Var, Bin, Mod, Div, DivN, Cmp, And, Or, Not, Cast, CastX, Elem, Len }
enum SK { Decl, Assign, If, For, Each, Ret, Break, Continue }

class GVar
{
    public string Name; public VT T; public bool Mut; public bool Assignable = true; public int Reads;
    public GVar(string name, VT t) { Name = name; T = t; }
}

class Ex
{
    public EK K; public VT T; public Ex A, B; public string Op; public double Val; public GVar Var, Var2;
    public Ex(EK k, VT t) { K = k; T = t; }
}

class St
{
    public SK K; public GVar Var, Arr; public Ex E; public int Bound;
    public List<St> Body = new List<St>();
    public List<St> Else = new List<St>();
    public St(SK k) { K = k; }
}

class GFn
{
    public List<GVar> Params = new List<GVar>();
    public VT Ret = VT.I;
    public List<St> Body = new List<St>();
    public string Desc = "";
    public List<string> Words = new List<string>();
}

static class Rn
{
    public static T Pick<T>(Random r, IList<T> l) { return l[r.Next(l.Count)]; }
    public static int Int(Random r, int a, int b) { return r.Next(a, b + 1); }
    public static bool Chance(Random r, double p) { return r.NextDouble() < p; }
    public static void AddN(List<string> l, string s, int n) { for (int i = 0; i < n; i++) l.Add(s); }
    public static string Fmt(string f, string a) { return f.Replace("%s", a); }
}

static class XB
{
    public static Ex Lit(VT t, double v) { Ex e = new Ex(EK.Lit, t); e.Val = v; return e; }
    public static Ex LitB(bool v) { return Lit(VT.B, v ? 1 : 0); }
    public static Ex Ref(GVar v) { Ex e = new Ex(EK.Var, v.T == VT.X ? VT.I : v.T); e.Var = v; return e; }
    public static Ex Bin(VT t, Ex a, Ex b, string op) { Ex e = new Ex(EK.Bin, t); e.A = a; e.B = b; e.Op = op; return e; }
    public static Ex Mod(Ex a, int v) { Ex e = new Ex(EK.Mod, VT.I); e.A = a; e.Val = v; return e; }
    public static Ex Div(Ex a, int v) { Ex e = new Ex(EK.Div, VT.I); e.A = a; e.Val = v; return e; }
    public static Ex DivN(Ex a, double v) { Ex e = new Ex(EK.DivN, VT.N); e.A = a; e.Val = v; return e; }
    public static Ex Cmp(Ex a, Ex b, string op) { Ex e = new Ex(EK.Cmp, VT.B); e.A = a; e.B = b; e.Op = op; return e; }
    public static Ex And(Ex a, Ex b) { Ex e = new Ex(EK.And, VT.B); e.A = a; e.B = b; return e; }
    public static Ex Or(Ex a, Ex b) { Ex e = new Ex(EK.Or, VT.B); e.A = a; e.B = b; return e; }
    public static Ex Not(Ex a) { Ex e = new Ex(EK.Not, VT.B); e.A = a; return e; }
    public static Ex Cast(Ex a) { Ex e = new Ex(EK.Cast, VT.N); e.A = a; return e; }
    public static Ex CastX(GVar v) { Ex e = new Ex(EK.CastX, VT.I); e.Var = v; return e; }
    public static Ex Elem(GVar arr, GVar idx) { Ex e = new Ex(EK.Elem, VT.I); e.Var = arr; e.Var2 = idx; return e; }
    public static Ex Len(GVar arr) { Ex e = new Ex(EK.Len, VT.I); e.Var = arr; return e; }

    public static St Decl(GVar v, Ex e) { St s = new St(SK.Decl); s.Var = v; s.E = e; return s; }
    public static St Assign(GVar v, Ex e) { St s = new St(SK.Assign); s.Var = v; s.E = e; return s; }
    public static St Ret(Ex e) { St s = new St(SK.Ret); s.E = e; return s; }
    public static St Flow(SK k) { return new St(k); }
    public static St If(Ex c, List<St> body, List<St> orelse)
    {
        St s = new St(SK.If); s.E = c; s.Body = body; if (orelse != null) s.Else = orelse; return s;
    }
    public static St ForN(GVar v, int bound, List<St> body) { St s = new St(SK.For); s.Var = v; s.Bound = bound; s.Body = body; return s; }
    public static St ForA(GVar v, GVar arr, List<St> body) { St s = new St(SK.For); s.Var = v; s.Arr = arr; s.Body = body; return s; }
    public static St Each(GVar v, GVar arr, List<St> body) { St s = new St(SK.Each); s.Var = v; s.Arr = arr; s.Body = body; return s; }
    public static List<St> L(params St[] a) { return new List<St>(a); }
}

static class GenWords
{
    public static readonly string[] Acc = { "total", "acc", "score", "sum", "result", "carry", "state", "mix", "mark", "anchor" };
    public static readonly string[] Cnt = { "count", "hits", "matches", "seen", "tally" };
    public static readonly string[] Tmp = { "delta", "diff", "cur", "prev", "next", "span", "gap", "edge", "step", "offset", "bound", "slot", "lane" };
    public static readonly string[] TmpCnt = { "delta", "diff", "cur", "prev", "next", "span", "gap", "edge", "step", "offset", "bound", "slot", "lane", "count", "hits", "matches", "seen", "tally" };
    public static readonly string[] NumV = { "ratio", "scale", "weight", "gain", "mean", "load", "rate", "drift", "bias" };
    public static readonly string[] BoolV = { "found", "ok", "valid", "flag", "ready", "stale" };
    public static readonly string[] Elem = { "item", "value", "sample", "entry", "cell", "reading", "datum" };
    public static readonly string[] ArrP = { "values", "samples", "items", "levels", "readings", "data", "series" };
    public static readonly string[] IntP = { "limit", "seed", "offset", "bound", "step", "origin", "target", "floor" };
    public static readonly string[] NumP = { "ratio", "scale", "weight", "gain", "bias", "rate" };
    public static readonly int[] Mods = { 2, 3, 5, 7, 8, 10, 12, 16, 24, 60, 64, 97, 100 };
    public static readonly int[] Masks = { 1, 3, 7, 15, 31, 63, 127, 255 };
    public static readonly int[] SelfMods = { 97, 101, 255, 1000, 4096, 65521 };
}

class Ctx
{
    public Random R;
    public List<List<GVar>> Scopes = new List<List<GVar>>();
    public HashSet<string> Names = new HashSet<string>();
    public List<GVar[]> Loops = new List<GVar[]>();
    public GFn Fn = new GFn();

    public Ctx(Random r) { R = r; Scopes.Add(new List<GVar>()); }

    string UName(string b)
    {
        string n = b; int k = 2;
        while (Names.Contains(n)) { n = b + k; k++; }
        Names.Add(n); return n;
    }
    public GVar NewVar(string b, VT t) { GVar v = new GVar(UName(b), t); Scopes[Scopes.Count - 1].Add(v); return v; }
    public GVar Param(string b, VT t) { GVar v = new GVar(UName(b), t); v.Assignable = false; Scopes[0].Add(v); Fn.Params.Add(v); return v; }
    public List<GVar> Vars(VT t)
    {
        var o = new List<GVar>();
        foreach (List<GVar> sc in Scopes) foreach (GVar v in sc) if (v.T == t) o.Add(v);
        return o;
    }
    public void Push() { Scopes.Add(new List<GVar>()); }
    public void Pop() { Scopes.RemoveAt(Scopes.Count - 1); }

    string PickS(string[] a) { return a[R.Next(a.Length)]; }
    int PickI(int[] a) { return a[R.Next(a.Length)]; }
    int Int(int a, int b) { return R.Next(a, b + 1); }
    bool Chance(double p) { return R.NextDouble() < p; }

    // ----- literals and expressions -----
    public Ex LitI()
    {
        int k = R.Next(3);
        int v = k == 0 ? Int(0, 9) : (k == 1 ? Int(10, 99) : Int(100, 999));
        if (R.NextDouble() <= 0.12) v = -v;
        return XB.Lit(VT.I, v);
    }

    public Ex LitN()
    {
        int k = R.Next(3);
        double v = k == 0 ? Int(1, 99) / 10.0 : (k == 1 ? Int(1, 999) / 100.0 : (double)Int(1, 20));
        return XB.Lit(VT.N, v);
    }

    public Ex GenI(int d)
    {
        var opts = new List<string>(); opts.Add("lit");
        List<GVar> vs = Vars(VT.I), xs = Vars(VT.X);
        if (vs.Count > 0) Rn.AddN(opts, "var", 4);
        if (Loops.Count > 0) Rn.AddN(opts, "elem", 3);
        if (xs.Count > 0) opts.Add("castx");
        if (d > 0)
        {
            Rn.AddN(opts, "add", 3); Rn.AddN(opts, "sub", 2);
            opts.AddRange(new string[] { "mul", "mod", "div", "xor", "and", "shr", "shl" });
        }
        List<GVar> arrs = Vars(VT.A);
        if (arrs.Count > 0 && Chance(0.15)) opts.Add("len");
        string k = Rn.Pick(R, opts);
        switch (k)
        {
            case "lit": return LitI();
            case "var": return XB.Ref(Rn.Pick(R, vs));
            case "elem": { GVar[] pr = Rn.Pick(R, Loops); return XB.Elem(pr[0], pr[1]); }
            case "castx": return XB.CastX(Rn.Pick(R, xs));
            case "len": return XB.Len(Rn.Pick(R, arrs));
            case "add": return XB.Bin(VT.I, GenI(d - 1), GenI(d - 1), "+");
            case "sub": return XB.Bin(VT.I, GenI(d - 1), GenI(d - 1), "-");
            case "mul": return XB.Bin(VT.I, GenI(d - 1), XB.Lit(VT.I, Int(2, 5)), "*");
            case "mod": return XB.Mod(GenI(d - 1), PickI(GenWords.Mods));
            case "div": return XB.Div(GenI(d - 1), Int(2, 9));
            case "xor": return XB.Bin(VT.I, GenI(d - 1), GenI(d - 1), "^");
            case "and": return XB.Bin(VT.I, GenI(d - 1), XB.Lit(VT.I, PickI(GenWords.Masks)), "&");
            case "shr": return XB.Bin(VT.I, GenI(d - 1), XB.Lit(VT.I, Int(1, 5)), ">>");
            default: return XB.Bin(VT.I, GenI(d - 1), XB.Lit(VT.I, Int(1, 3)), "<<");
        }
    }

    public Ex GenN(int d)
    {
        var opts = new List<string>(); opts.Add("lit");
        List<GVar> vs = Vars(VT.N);
        if (vs.Count > 0) Rn.AddN(opts, "var", 4);
        if (d > 0) opts.AddRange(new string[] { "add", "sub", "mul", "div", "cast", "cast" });
        string k = Rn.Pick(R, opts);
        switch (k)
        {
            case "lit": return LitN();
            case "var": return XB.Ref(Rn.Pick(R, vs));
            case "cast": return XB.Cast(GenI(d - 1));
            case "div": return XB.DivN(GenN(d - 1), Int(2, 9));
            case "mul": return XB.Bin(VT.N, GenN(d - 1), LitN(), "*");
            case "add": return XB.Bin(VT.N, GenN(d - 1), GenN(d - 1), "+");
            default: return XB.Bin(VT.N, GenN(d - 1), GenN(d - 1), "-");
        }
    }

    // True when the expression contains no variable, so a comparison of two such would be a constant.
    public static bool IsConst(Ex e)
    {
        switch (e.K)
        {
            case EK.Lit: return true;
            case EK.Var: case EK.Elem: case EK.CastX: case EK.Len: return false;
            case EK.Bin: case EK.Cmp: case EK.And: case EK.Or: return IsConst(e.A) && IsConst(e.B);
            default: return IsConst(e.A);
        }
    }

    public Ex GenB(int d)
    {
        var opts = new List<string>();
        Rn.AddN(opts, "cmpi", 5); Rn.AddN(opts, "cmpn", 2);
        if (d > 0) opts.AddRange(new string[] { "and", "or", "not" });
        if (Vars(VT.B).Count > 0) opts.Add("var");
        string k = Rn.Pick(R, opts);
        string[] ops = { "<", "<=", ">", ">=", "==", "!=" };
        if (k == "cmpi" || k == "cmpn")
        {
            Ex a = null, b = null;
            for (int t = 0; t < 8; t++)
            {
                a = k == "cmpi" ? GenI(1) : GenN(1);
                b = k == "cmpi" ? GenI(1) : GenN(1);
                if ((IsConst(a) && IsConst(b)) || Rx.Render(Lang.Py, a) == Rx.Render(Lang.Py, b)) continue;
                break;
            }
            string op = PickS(ops);
            string[] rel = { "<", ">", "<=", ">=" };
            if (IsConst(a) && IsConst(b)) op = PickS(rel);
            else if ((op == "==" || op == "!=") && (a.K == EK.Var || a.K == EK.Lit || b.K == EK.Var || b.K == EK.Lit) && a.K != EK.Elem && b.K != EK.Elem)
                op = PickS(rel);
            return XB.Cmp(a, b, op);
        }
        if (k == "and") return XB.And(GenB(d - 1), GenB(d - 1));
        if (k == "or") return XB.Or(GenB(d - 1), GenB(d - 1));
        if (k == "not") return XB.Not(GenB(d - 1));
        return XB.Ref(Rn.Pick(R, Vars(VT.B)));
    }

    public Ex SelfUpdate(GVar v)
    {
        if (v.T == VT.I)
        {
            Ex bs = XB.Ref(v);
            string k = PickS(new string[] { "add", "sub", "mix", "xor", "mul" });
            Ex other = GenI(1);
            Ex e;
            if (k == "add") e = XB.Bin(VT.I, bs, other, "+");
            else if (k == "sub") e = XB.Bin(VT.I, bs, other, "-");
            else if (k == "xor") e = XB.Bin(VT.I, bs, other, "^");
            else if (k == "mul") e = XB.Bin(VT.I, XB.Bin(VT.I, bs, XB.Lit(VT.I, Int(2, 5)), "*"), other, "+");
            else e = XB.Bin(VT.I, XB.Bin(VT.I, bs, XB.Lit(VT.I, Int(2, 3)), "<<"), other, "^");
            if (Chance(0.6)) e = XB.Mod(e, PickI(GenWords.SelfMods));
            return e;
        }
        if (v.T == VT.N) return XB.Bin(VT.N, XB.Ref(v), GenN(1), Chance(0.5) ? "+" : "-");
        return GenB(1);
    }

    // ----- statements -----
    public List<St> GenBlock(int n, int d, bool inLoop)
    {
        var o = new List<St>();
        Push();
        for (int q = 0; q < n; q++)
        {
            var opts = new List<string>();
            Rn.AddN(opts, "decl", 3); Rn.AddN(opts, "assign", 3);
            if (d > 0) { Rn.AddN(opts, "if", 3); opts.Add("for"); }
            string k = Rn.Pick(R, opts);
            if (k == "decl")
            {
                int t = R.Next(5);
                if (t <= 2) { Ex e = GenI(2); GVar v = NewVar(PickS(GenWords.TmpCnt), VT.I); o.Add(XB.Decl(v, e)); }
                else if (t == 3) { Ex e = GenN(2); GVar v = NewVar(PickS(GenWords.NumV), VT.N); o.Add(XB.Decl(v, e)); }
                else { Ex e = GenB(1); GVar v = NewVar(PickS(GenWords.BoolV), VT.B); o.Add(XB.Decl(v, e)); }
            }
            else if (k == "assign")
            {
                var cand = new List<GVar>();
                foreach (GVar v in Vars(VT.I)) if (v.Assignable) cand.Add(v);
                foreach (GVar v in Vars(VT.N)) if (v.Assignable) cand.Add(v);
                foreach (GVar v in Vars(VT.B)) if (v.Assignable) cand.Add(v);
                if (cand.Count == 0) continue;
                GVar pv = Rn.Pick(R, cand); pv.Mut = true;
                o.Add(XB.Assign(pv, SelfUpdate(pv)));
            }
            else if (k == "if")
            {
                List<St> then = GenBlock(Int(1, 2), d - 1, inLoop);
                if (inLoop && Chance(0.2)) then.Add(XB.Flow(Chance(0.5) ? SK.Break : SK.Continue));
                List<St> orelse = Chance(0.45) ? GenBlock(Int(1, 2), d - 1, inLoop) : new List<St>();
                o.Add(XB.If(GenB(1), then, orelse));
            }
            else
            {
                Push();
                GVar iv = NewVar("i", VT.X); iv.Assignable = false;
                List<St> body = GenBlock(Int(1, 2), d - 1, true);
                Pop();
                o.Add(XB.ForN(iv, Int(2, 12), body));
            }
        }
        Pop();
        if (o.Count == 0)
        {
            Ex e = GenI(1); GVar v = NewVar(PickS(GenWords.Tmp), VT.I);
            o.Add(XB.Decl(v, e));
        }
        return o;
    }
}

// ---------------------------------------------------------------------
//  Function families: each builds a different kind of small routine.
// ---------------------------------------------------------------------
static class Families
{
    static string P(Random r, string[] a) { return a[r.Next(a.Length)]; }
    static int I(Random r, int a, int b) { return r.Next(a, b + 1); }
    static bool C(Random r, double p) { return r.NextDouble() < p; }
    static int PI(Random r, int[] a) { return a[r.Next(a.Length)]; }
    static List<string> W(params string[] w) { return new List<string>(w); }

    public static GFn Make(Random r, string noun)
    {
        Ctx c = new Ctx(r);
        switch (r.Next(10))
        {
            case 0: case 1: Reduce(c, noun); break;
            case 2: Search(c, noun); break;
            case 3: case 4: Count(c, noun); break;
            case 5: Series(c, noun); break;
            case 6: Classify(c, noun); break;
            case 7: Numeric(c, noun); break;
            case 8: Pairs(c, noun); break;
            default: Flag(c, noun); break;
        }
        return c.Fn;
    }

    static void Reduce(Ctx c, string noun)
    {
        Random r = c.R;
        GVar arr = c.Param(P(r, GenWords.ArrP), VT.A);
        if (C(r, 0.5)) c.Param(P(r, GenWords.IntP), VT.I);
        GVar acc = c.NewVar(P(r, GenWords.Acc), VT.I); acc.Mut = true;
        var st = new List<St>();
        st.Add(XB.Decl(acc, c.LitI()));
        c.Push();
        GVar x = c.NewVar(P(r, GenWords.Elem), VT.I); x.Assignable = false;
        var inner = new List<St>();
        acc.Assignable = true;
        if (C(r, 0.5)) inner.AddRange(c.GenBlock(I(r, 1, 2), 1, true));
        St upd = XB.Assign(acc, c.SelfUpdate(acc));
        if (C(r, 0.6))
        {
            List<St> orelse = C(r, 0.3) ? XB.L(XB.Assign(acc, c.SelfUpdate(acc))) : new List<St>();
            inner.Add(XB.If(c.GenB(1), XB.L(upd), orelse));
        }
        else inner.Add(upd);
        if (C(r, 0.15)) inner.Add(XB.If(c.GenB(1), XB.L(XB.Flow(SK.Break)), null));
        c.Pop();
        st.Add(XB.Each(x, arr, inner));
        if (C(r, 0.4))
            st.Add(XB.If(XB.Cmp(XB.Ref(acc), c.LitI(), C(r, 0.5) ? "<" : ">"), XB.L(XB.Assign(acc, c.SelfUpdate(acc))), null));
        int[] rm = { 97, 1000, 4096, 65521 };
        st.Add(XB.Ret(C(r, 0.6) ? XB.Ref(acc) : XB.Mod(XB.Ref(acc), PI(r, rm))));
        c.Fn.Ret = VT.I; c.Fn.Body = st;
        c.Fn.Words = W(P(r, new string[] { "total", "fold", "combine", "tally", "weigh", "score", "digest" }), noun);
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "combine %s values into a single score", "fold a list of %s readings", "accumulate %s samples", "digest a series of %s entries" }), noun);
    }

    static void Search(Ctx c, string noun)
    {
        Random r = c.R;
        GVar arr = c.Param(P(r, GenWords.ArrP), VT.A);
        GVar tgt = c.Param(P(r, GenWords.IntP), VT.I);
        c.Push();
        GVar iv = c.NewVar("i", VT.X); iv.Assignable = false;
        c.Loops.Add(new GVar[] { arr, iv });
        Ex elem = XB.Elem(arr, iv);
        Ex cond = XB.Cmp(elem, XB.Ref(tgt), P(r, new string[] { "==", ">", "<", ">=", "<=" }));
        if (C(r, 0.4))
            cond = XB.And(cond, XB.Cmp(XB.Mod(elem, PI(r, new int[] { 2, 3, 5 })), XB.Lit(VT.I, 0), C(r, 0.5) ? "==" : "!="));
        var body = XB.L(XB.If(cond, XB.L(XB.Ret(XB.CastX(iv))), null));
        if (C(r, 0.4))
        {
            Ex e0 = c.GenI(2);
            body.Insert(0, XB.Decl(c.NewVar(P(r, GenWords.Tmp), VT.I), e0));
        }
        c.Loops.RemoveAt(c.Loops.Count - 1);
        c.Pop();
        c.Fn.Body = XB.L(XB.ForA(iv, arr, body), XB.Ret(XB.Lit(VT.I, -1)));
        c.Fn.Ret = VT.I;
        c.Fn.Words = W(P(r, new string[] { "find", "locate", "seek", "lookup" }), noun, "index");
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "find the first %s entry that matches the target", "locate a %s reading by value", "look up the position of a %s sample" }), noun);
    }

    static void Count(Ctx c, string noun)
    {
        Random r = c.R;
        GVar arr = c.Param(P(r, GenWords.ArrP), VT.A);
        if (C(r, 0.5)) c.Param(P(r, GenWords.IntP), VT.I);
        GVar cnt = c.NewVar(P(r, GenWords.Cnt), VT.I); cnt.Mut = true;
        var st = new List<St>();
        st.Add(XB.Decl(cnt, XB.Lit(VT.I, 0)));
        c.Push();
        GVar x = c.NewVar(P(r, GenWords.Elem), VT.I); x.Assignable = false;
        Ex cond = c.GenB(2);
        St inc = XB.Assign(cnt, XB.Bin(VT.I, XB.Ref(cnt), XB.Lit(VT.I, I(r, 1, 3)), "+"));
        List<St> orelse = C(r, 0.25) ? XB.L(XB.Assign(cnt, XB.Bin(VT.I, XB.Ref(cnt), XB.Lit(VT.I, 1), "-"))) : new List<St>();
        var inner = XB.L(XB.If(cond, XB.L(inc), orelse));
        c.Pop();
        st.Add(XB.Each(x, arr, inner));
        st.Add(XB.Ret(XB.Ref(cnt)));
        c.Fn.Body = st; c.Fn.Ret = VT.I;
        c.Fn.Words = W(P(r, new string[] { "count", "measure", "tally", "audit" }), noun, P(r, new string[] { "hits", "matches", "outliers", "gaps" }));
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "count the %s entries that pass the check", "measure how many %s samples are out of range", "audit %s readings against a rule" }), noun);
    }

    static void Series(Ctx c, string noun)
    {
        Random r = c.R;
        GVar seed = c.Param(P(r, GenWords.IntP), VT.I);
        GVar acc = c.NewVar(P(r, GenWords.Acc), VT.I); acc.Mut = true;
        var st = new List<St>();
        st.Add(XB.Decl(acc, XB.Ref(seed)));
        c.Push();
        GVar iv = c.NewVar("i", VT.X); iv.Assignable = false;
        List<St> inner = c.GenBlock(I(r, 1, 3), 1, true);
        int[] sm = { 97, 101, 1000, 4093, 65521 };
        inner.Add(XB.Assign(acc, XB.Mod(XB.Bin(VT.I, XB.Bin(VT.I, XB.Ref(acc), XB.Lit(VT.I, I(r, 2, 5)), "*"), XB.CastX(iv), "+"), PI(r, sm))));
        c.Pop();
        st.Add(XB.ForN(iv, I(r, 4, 24), inner));
        st.Add(XB.Ret(XB.Ref(acc)));
        c.Fn.Body = st; c.Fn.Ret = VT.I;
        c.Fn.Words = W(P(r, new string[] { "step", "series", "roll", "derive", "iterate" }), noun);
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "derive the next %s value from a seed", "roll a %s counter forward", "iterate the %s series from a seed" }), noun);
    }

    static void Classify(Ctx c, string noun)
    {
        Random r = c.R;
        GVar a = c.Param(P(r, GenWords.IntP), VT.I);
        GVar b = c.Param(P(r, GenWords.IntP), VT.I);
        var st = new List<St>();
        if (C(r, 0.5))
        {
            GVar d = c.NewVar(P(r, GenWords.Tmp), VT.I);
            st.Add(XB.Decl(d, XB.Bin(VT.I, XB.Ref(a), XB.Ref(b), P(r, new string[] { "-", "+", "^" }))));
        }
        int levels = I(r, 2, 4);
        var pool = new List<int>();
        for (int q = 0; q < 9; q++) pool.Add(q);
        var rets = new List<int>();
        for (int q = 0; q < levels + 1; q++) { int ix = r.Next(pool.Count); rets.Add(pool[ix]); pool.RemoveAt(ix); }
        List<St> node = XB.L(XB.Ret(XB.Lit(VT.I, rets[rets.Count - 1])));
        for (int k = 0; k < levels; k++)
        {
            Ex cond = c.GenB(1);
            node = XB.L(XB.If(cond, XB.L(XB.Ret(XB.Lit(VT.I, rets[k]))), node));
        }
        st.AddRange(node);
        c.Fn.Body = st; c.Fn.Ret = VT.I;
        c.Fn.Words = W(P(r, new string[] { "classify", "grade", "rank", "bucket", "sort" }), noun);
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "classify a %s pair into a bucket", "grade a %s value against two limits", "rank %s input into a small class" }), noun);
    }

    static void Numeric(Ctx c, string noun)
    {
        Random r = c.R;
        c.Param(P(r, GenWords.NumP), VT.N);
        c.Param(P(r, new string[] { "bias", "offset", "floor", "span" }), VT.N);
        var st = new List<St>();
        Ex e0 = c.GenN(2);
        GVar t = c.NewVar(P(r, GenWords.NumV), VT.N); t.Mut = true;
        st.Add(XB.Decl(t, e0));
        if (C(r, 0.7))
        {
            Ex rhs = c.GenN(1);
            string op = P(r, new string[] { "<", ">", "<=", ">=" });
            List<St> orelse = C(r, 0.4) ? XB.L(XB.Assign(t, c.SelfUpdate(t))) : new List<St>();
            st.Add(XB.If(XB.Cmp(XB.Ref(t), rhs, op), XB.L(XB.Assign(t, c.SelfUpdate(t))), orelse));
        }
        if (C(r, 0.5))
        {
            c.Push();
            GVar iv = c.NewVar("i", VT.X); iv.Assignable = false;
            st.Add(XB.ForN(iv, I(r, 2, 9), XB.L(XB.Assign(t, c.SelfUpdate(t)))));
            c.Pop();
        }
        st.Add(XB.Ret(XB.Bin(VT.N, XB.Ref(t), c.GenN(1), C(r, 0.5) ? "+" : "-")));
        c.Fn.Body = st; c.Fn.Ret = VT.N;
        c.Fn.Words = W(P(r, new string[] { "blend", "scale", "adjust", "project", "smooth" }), noun);
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "blend two %s measurements", "scale a %s figure with a bias", "adjust a %s reading", "project the next %s value" }), noun);
    }

    static void Pairs(Ctx c, string noun)
    {
        Random r = c.R;
        GVar arr = c.Param(P(r, GenWords.ArrP), VT.A);
        GVar cnt = c.NewVar(P(r, GenWords.Cnt), VT.I); cnt.Mut = true;
        var st = new List<St>();
        st.Add(XB.Decl(cnt, XB.Lit(VT.I, 0)));
        c.Push();
        GVar i = c.NewVar("i", VT.X); i.Assignable = false;
        c.Push();
        GVar j = c.NewVar("j", VT.X); j.Assignable = false;
        Ex ea = XB.Elem(arr, i), eb = XB.Elem(arr, j);
        Ex cond = XB.Cmp(XB.Bin(VT.I, ea, eb, P(r, new string[] { "+", "-", "^" })), XB.Lit(VT.I, I(r, 0, 20)), P(r, new string[] { "==", ">", "<", "!=" }));
        var inner = XB.L(XB.If(cond, XB.L(XB.Assign(cnt, XB.Bin(VT.I, XB.Ref(cnt), XB.Lit(VT.I, 1), "+"))), null));
        c.Pop(); c.Pop();
        st.Add(XB.ForA(i, arr, XB.L(XB.ForA(j, arr, inner))));
        st.Add(XB.Ret(XB.Ref(cnt)));
        c.Fn.Body = st; c.Fn.Ret = VT.I;
        c.Fn.Words = W(P(r, new string[] { "pair", "match", "compare", "overlap" }), noun, "count");
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "count %s pairs that satisfy a relation", "compare every pair of %s readings", "match up %s samples" }), noun);
    }

    static void Flag(Ctx c, string noun)
    {
        Random r = c.R;
        GVar arr = c.Param(P(r, GenWords.ArrP), VT.A);
        GVar lim = c.Param(P(r, GenWords.IntP), VT.I);
        GVar ok = c.NewVar(P(r, GenWords.BoolV), VT.B); ok.Mut = true;
        var st = new List<St>();
        st.Add(XB.Decl(ok, XB.LitB(true)));
        c.Push();
        GVar x = c.NewVar(P(r, GenWords.Elem), VT.I); x.Assignable = false;
        Ex cond = XB.Cmp(XB.Ref(x), XB.Ref(lim), P(r, new string[] { ">", "<", ">=", "<=", "!=" }));
        var inner = XB.L(XB.If(cond, XB.L(XB.Assign(ok, XB.LitB(false)), XB.Flow(SK.Break)), null));
        c.Pop();
        st.Add(XB.Each(x, arr, inner));
        st.Add(XB.Ret(XB.Ref(ok)));
        c.Fn.Body = st; c.Fn.Ret = VT.B;
        c.Fn.Words = W(P(r, new string[] { "check", "verify", "validate", "guard" }), noun, P(r, new string[] { "limits", "bounds", "range" }));
        c.Fn.Desc = Rn.Fmt(P(r, new string[] { "check that every %s entry stays within the limit", "validate %s readings against a bound" }), noun);
    }
}


// ---------------------------------------------------------------------
//  Rendering: expression and statement trees to source text.
// ---------------------------------------------------------------------
static class Rx
{
    static readonly System.Globalization.CultureInfo Inv = System.Globalization.CultureInfo.InvariantCulture;

    public static string Num(double v)
    {
        string s = v.ToString("0.##", Inv);
        if (s.IndexOf('.') < 0) s += ".0";
        return s;
    }

    public static string Int(double v) { return ((long)v).ToString(Inv); }

    static string LitS(Lang L, Ex e)
    {
        if (e.T == VT.B)
        {
            bool v = e.Val != 0;
            return L == Lang.Py ? (v ? "True" : "False") : (v ? "true" : "false");
        }
        if (e.T == VT.N) return Num(e.Val);
        return e.Val < 0 ? "(" + Int(e.Val) + ")" : Int(e.Val);
    }

    public static string Render(Lang L, Ex e)
    {
        switch (e.K)
        {
            case EK.Lit: return LitS(L, e);
            case EK.Var: return e.Var.Name;
            case EK.Bin: return "(" + Render(L, e.A) + " " + e.Op + " " + Render(L, e.B) + ")";
            case EK.Mod: return "(" + Render(L, e.A) + " % " + Int(e.Val) + ")";
            case EK.Div:
                if (L == Lang.Py) return "(" + Render(L, e.A) + " // " + Int(e.Val) + ")";
                if (L == Lang.Js || L == Lang.Ts) return "Math.trunc(" + Render(L, e.A) + " / " + Int(e.Val) + ")";
                return "(" + Render(L, e.A) + " / " + Int(e.Val) + ")";
            case EK.DivN: return "(" + Render(L, e.A) + " / " + Num(e.Val) + ")";
            case EK.Cmp: return "(" + Render(L, e.A) + " " + e.Op + " " + Render(L, e.B) + ")";
            case EK.And: return "(" + Render(L, e.A) + (L == Lang.Py ? " and " : " && ") + Render(L, e.B) + ")";
            case EK.Or: return "(" + Render(L, e.A) + (L == Lang.Py ? " or " : " || ") + Render(L, e.B) + ")";
            case EK.Not: return (L == Lang.Py ? "not " : "!") + Render(L, e.A);
            case EK.Cast:
            {
                string x = Render(L, e.A);
                switch (L)
                {
                    case Lang.Py: return "float(" + x + ")";
                    case Lang.Js: case Lang.Ts: return x;
                    case Lang.Cs: return "(double)" + x;
                    case Lang.Java: return "(double) " + x;
                    case Lang.Go: return "float64(" + x + ")";
                    case Lang.Rust: return "(" + x + " as f64)";
                    default: return "static_cast<double>(" + x + ")";
                }
            }
            case EK.CastX:
            {
                string n = e.Var.Name;
                switch (L)
                {
                    case Lang.Py: case Lang.Js: case Lang.Ts: return n;
                    case Lang.Cs: return "(long)" + n;
                    case Lang.Java: return "(long) " + n;
                    case Lang.Go: return "int64(" + n + ")";
                    case Lang.Rust: return "(" + n + " as i64)";
                    default: return "static_cast<long long>(" + n + ")";
                }
            }
            case EK.Elem: return e.Var.Name + "[" + e.Var2.Name + "]";
            default:
            {
                string n = e.Var.Name;
                switch (L)
                {
                    case Lang.Py: return "len(" + n + ")";
                    case Lang.Js: case Lang.Ts: return n + ".length";
                    case Lang.Cs: return "(long)" + n + ".Length";
                    case Lang.Java: return "(long) " + n + ".length";
                    case Lang.Go: return "int64(len(" + n + "))";
                    case Lang.Rust: return "(" + n + ".len() as i64)";
                    default: return "static_cast<long long>(" + n + ".size())";
                }
            }
        }
    }

    // Drops one pair of outer parentheses when they enclose the whole expression.
    public static string Strip(string x)
    {
        if (x.Length > 1 && x[0] == '(' && x[x.Length - 1] == ')')
        {
            int depth = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '(') depth++;
                else if (x[i] == ')')
                {
                    depth--;
                    if (depth == 0 && i < x.Length - 1) return x;
                }
            }
            return x.Substring(1, x.Length - 2);
        }
        return x;
    }

    public static string Top(Lang L, Ex e) { return Strip(Render(L, e)); }
}

static class FnRender
{
    static void Walk(Ex e, Action<Ex> f)
    {
        if (e == null) return;
        f(e); Walk(e.A, f); Walk(e.B, f);
    }

    static void CollectVars(List<St> stmts, HashSet<GVar> acc)
    {
        foreach (St s in stmts)
        {
            if (s.Var != null) acc.Add(s.Var);
            if (s.Arr != null) acc.Add(s.Arr);
            if (s.E != null)
                Walk(s.E, delegate (Ex e) { if (e.Var != null) acc.Add(e.Var); if (e.Var2 != null) acc.Add(e.Var2); });
            CollectVars(s.Body, acc); CollectVars(s.Else, acc);
        }
    }

    static void CountReads(List<St> stmts)
    {
        foreach (St s in stmts)
        {
            if (s.E != null)
            {
                GVar own = s.K == SK.Assign ? s.Var : null;
                Walk(s.E, delegate (Ex e)
                {
                    if ((e.K == EK.Var || e.K == EK.CastX) && e.Var != own) e.Var.Reads++;
                    if (e.K == EK.Elem) e.Var2.Reads++;
                });
            }
            CountReads(s.Body); CountReads(s.Else);
        }
    }

    static List<St> StripDead(List<St> stmts, HashSet<GVar> dead)
    {
        var o = new List<St>();
        foreach (St s in stmts)
        {
            if ((s.K == SK.Decl || s.K == SK.Assign) && dead.Contains(s.Var)) continue;
            s.Body = StripDead(s.Body, dead); s.Else = StripDead(s.Else, dead);
            if (s.K == SK.If)
            {
                if (s.Body.Count == 0 && s.Else.Count > 0) { s.E = XB.Not(s.E); s.Body = s.Else; s.Else = new List<St>(); }
                else if (s.Body.Count == 0) continue;
            }
            if ((s.K == SK.For || s.K == SK.Each) && s.Body.Count == 0) continue;
            o.Add(s);
        }
        return o;
    }

    static void DeclVars(List<St> stmts, HashSet<GVar> acc)
    {
        foreach (St s in stmts)
        {
            if (s.K == SK.Decl) acc.Add(s.Var);
            DeclVars(s.Body, acc); DeclVars(s.Else, acc);
        }
    }

    static void ResetReads(GFn f)
    {
        var vs = new HashSet<GVar>();
        CollectVars(f.Body, vs);
        foreach (GVar p in f.Params) vs.Add(p);
        foreach (GVar v in vs) v.Reads = 0;
        CountReads(f.Body);
    }

    static void Prune(GFn f)
    {
        while (true)
        {
            ResetReads(f);
            var ds = new HashSet<GVar>(); DeclVars(f.Body, ds);
            var dead = new HashSet<GVar>();
            foreach (GVar v in ds) if (v.Reads == 0) dead.Add(v);
            if (dead.Count == 0) break;
            f.Body = StripDead(f.Body, dead);
        }
    }

    static St FirstAssign(List<St> stmts, VT t1, VT t2)
    {
        foreach (St s in stmts)
        {
            if (s.K == SK.Assign && (s.Var.T == t1 || s.Var.T == t2)) return s;
            St r = FirstAssign(s.Body, t1, t2);
            if (r != null) return r;
            r = FirstAssign(s.Else, t1, t2);
            if (r != null) return r;
        }
        return null;
    }

    static void Inject(St s, Ex add, string op)
    {
        VT ty = s.Var.T;
        if (ty == VT.N && add.T == VT.I) add = XB.Cast(add);
        if (ty == VT.I && add.T == VT.N) return;
        if (ty == VT.N && op == "^") op = "+";
        s.E = XB.Bin(ty, s.E, add, op);
    }

    static void FeedLoops(List<St> stmts, Random r)
    {
        string[] ops = { "+", "-", "^" };
        foreach (St s in stmts)
        {
            FeedLoops(s.Body, r); FeedLoops(s.Else, r);
            if ((s.K == SK.For || s.K == SK.Each) && s.Var.Reads == 0)
            {
                St a = FirstAssign(s.Body, VT.I, VT.N);
                if (a == null) continue;
                string op = ops[r.Next(ops.Length)];
                if (s.K == SK.Each) Inject(a, XB.Ref(s.Var), op);
                else Inject(a, XB.CastX(s.Var), op);
                s.Var.Reads++;
            }
        }
    }

    static void MarkMut(List<St> stmts)
    {
        foreach (St s in stmts)
        {
            if (s.K == SK.Assign) s.Var.Mut = true;
            MarkMut(s.Body); MarkMut(s.Else);
        }
    }

    static void FeedParams(GFn f, Random r)
    {
        foreach (GVar p in f.Params)
        {
            if ((p.T == VT.I || p.T == VT.N) && p.Reads == 0)
            {
                St last = null;
                foreach (St s in f.Body) if (s.K == SK.Ret) last = s;
                St a = FirstAssign(f.Body, p.T, p.T);
                string op = r.Next(2) == 0 ? "+" : "-";
                if (a != null) Inject(a, XB.Ref(p), op);
                else if (last != null && last.E.T == p.T && last.E.K != EK.Lit) last.E = XB.Bin(p.T, last.E, XB.Ref(p), "+");
            }
        }
    }

    static readonly Dictionary<Lang, string[]> Types = new Dictionary<Lang, string[]>   // I, N, B, A
    {
        { Lang.Ts, new string[] { "number", "number", "boolean", "number[]" } },
        { Lang.Cs, new string[] { "long", "double", "bool", "long[]" } },
        { Lang.Java, new string[] { "long", "double", "boolean", "long[]" } },
        { Lang.Go, new string[] { "int64", "float64", "bool", "[]int64" } },
        { Lang.Rust, new string[] { "i64", "f64", "bool", "&[i64]" } },
        { Lang.Cpp, new string[] { "long long", "double", "bool", "const std::vector<long long>&" } },
    };

    public static string TypeOf(Lang L, VT t)
    {
        return Types[L][t == VT.I ? 0 : (t == VT.N ? 1 : (t == VT.B ? 2 : 3))];
    }

    static string Decl(Lang L, GVar v, Ex e, string ind)
    {
        string n = v.Name, x = Rx.Top(L, e);
        switch (L)
        {
            case Lang.Py: return ind + n + " = " + x;
            case Lang.Js: return ind + "let " + n + " = " + x + ";";
            case Lang.Ts: return ind + "let " + n + ": " + TypeOf(L, v.T) + " = " + x + ";";
            case Lang.Cs: case Lang.Java: case Lang.Cpp: return ind + TypeOf(L, v.T) + " " + n + " = " + x + ";";
            case Lang.Go: return ind + "var " + n + " " + TypeOf(L, v.T) + " = " + x;
            default: return ind + "let " + (v.Mut ? "mut " : "") + n + ": " + TypeOf(L, v.T) + " = " + x + ";";
        }
    }

    static void Stmts(Lang L, List<St> stmts, string ind, string unit, List<string> o)
    {
        foreach (St s in stmts)
        {
            string semi = (L == Lang.Py || L == Lang.Go) ? "" : ";";
            switch (s.K)
            {
                case SK.Decl:
                    o.Add(Decl(L, s.Var, s.E, ind));
                    if (L == Lang.Go && s.Var.Reads == 0) o.Add(ind + "_ = " + s.Var.Name);
                    break;
                case SK.Assign: o.Add(ind + s.Var.Name + " = " + Rx.Top(L, s.E) + semi); break;
                case SK.Ret: o.Add(ind + "return " + Rx.Top(L, s.E) + semi); break;
                case SK.Break: o.Add(ind + "break" + semi); break;
                case SK.Continue: o.Add(ind + "continue" + semi); break;
                case SK.If: IfStmt(L, s, ind, unit, o); break;
                case SK.For: ForStmt(L, s, ind, unit, o); break;
                case SK.Each: EachStmt(L, s, ind, unit, o); break;
            }
        }
    }

    static void IfStmt(Lang L, St s, string ind, string unit, List<string> o)
    {
        string cond = Rx.Top(L, s.E);
        if (L == Lang.Py)
        {
            o.Add(ind + "if " + cond + ":"); Stmts(L, s.Body, ind + unit, unit, o);
            if (s.Else.Count > 0) { o.Add(ind + "else:"); Stmts(L, s.Else, ind + unit, unit, o); }
            return;
        }
        string head = (L == Lang.Go || L == Lang.Rust) ? "if " + cond : "if (" + cond + ")";
        if (L == Lang.Cs)
        {
            o.Add(ind + head); o.Add(ind + "{"); Stmts(L, s.Body, ind + unit, unit, o); o.Add(ind + "}");
            if (s.Else.Count > 0) { o.Add(ind + "else"); o.Add(ind + "{"); Stmts(L, s.Else, ind + unit, unit, o); o.Add(ind + "}"); }
            return;
        }
        o.Add(ind + head + " {"); Stmts(L, s.Body, ind + unit, unit, o);
        if (s.Else.Count > 0) { o.Add(ind + "} else {"); Stmts(L, s.Else, ind + unit, unit, o); }
        o.Add(ind + "}");
    }

    static void ForStmt(Lang L, St s, string ind, string unit, List<string> o)
    {
        string i = s.Var.Name;
        string a = s.Arr != null ? s.Arr.Name : null;
        string n = s.Bound.ToString();
        string head;
        switch (L)
        {
            case Lang.Py: head = "for " + i + " in range(" + (a == null ? n : "len(" + a + ")") + "):"; break;
            case Lang.Js: case Lang.Ts: head = "for (let " + i + " = 0; " + i + " < " + (a == null ? n : a + ".length") + "; " + i + "++) {"; break;
            case Lang.Cs: head = "for (int " + i + " = 0; " + i + " < " + (a == null ? n : a + ".Length") + "; " + i + "++)"; break;
            case Lang.Java: head = "for (int " + i + " = 0; " + i + " < " + (a == null ? n : a + ".length") + "; " + i + "++) {"; break;
            case Lang.Go: head = "for " + i + " := 0; " + i + " < " + (a == null ? n : "len(" + a + ")") + "; " + i + "++ {"; break;
            case Lang.Rust: head = "for " + i + " in 0.." + (a == null ? n : a + ".len()") + " {"; break;
            default:
                head = a == null ? "for (int " + i + " = 0; " + i + " < " + n + "; ++" + i + ") {"
                                 : "for (std::size_t " + i + " = 0; " + i + " < " + a + ".size(); ++" + i + ") {";
                break;
        }
        o.Add(ind + head);
        if (L == Lang.Cs) o.Add(ind + "{");
        Stmts(L, s.Body, ind + unit, unit, o);
        if (L != Lang.Py) o.Add(ind + "}");
    }

    static void EachStmt(Lang L, St s, string ind, string unit, List<string> o)
    {
        string x = s.Var.Name, a = s.Arr.Name;
        bool used = s.Var.Reads > 0;
        string head;
        switch (L)
        {
            case Lang.Py: head = "for " + x + " in " + a + ":"; break;
            case Lang.Js: case Lang.Ts: head = "for (const " + x + " of " + a + ") {"; break;
            case Lang.Cs: head = "foreach (long " + x + " in " + a + ")"; break;
            case Lang.Java: head = "for (long " + x + " : " + a + ") {"; break;
            case Lang.Go: head = used ? "for _, " + x + " := range " + a + " {" : "for range " + a + " {"; break;
            case Lang.Rust: head = "for &" + x + " in " + a + ".iter() {"; break;
            default: head = "for (long long " + x + " : " + a + ") {"; break;
        }
        o.Add(ind + head);
        if (L == Lang.Cs) o.Add(ind + "{");
        Stmts(L, s.Body, ind + unit, unit, o);
        if (L != Lang.Py) o.Add(ind + "}");
    }

    // Renders the function in the given language. Returns the code; the name comes back in f.Words.
    public static string Render(Lang L, GFn f, string name)
    {
        Prune(f);
        var rr = new Random(f.Words.Count * 7 + f.Desc.Length);
        ResetReads(f); FeedLoops(f.Body, rr); ResetReads(f); FeedParams(f, rr);
        var vs = new HashSet<GVar>(); CollectVars(f.Body, vs);
        foreach (GVar v in vs) v.Mut = false;
        MarkMut(f.Body);
        ResetReads(f);
        var ps = new List<string>();
        string sig;
        switch (L)
        {
            case Lang.Py:
                foreach (GVar p in f.Params) ps.Add(p.Name);
                sig = "def " + name + "(" + string.Join(", ", ps.ToArray()) + "):"; break;
            case Lang.Js:
                foreach (GVar p in f.Params) ps.Add(p.Name);
                sig = "export function " + name + "(" + string.Join(", ", ps.ToArray()) + ") {"; break;
            case Lang.Ts:
                foreach (GVar p in f.Params) ps.Add(p.Name + ": " + TypeOf(L, p.T));
                sig = "export function " + name + "(" + string.Join(", ", ps.ToArray()) + "): " + TypeOf(L, f.Ret) + " {"; break;
            case Lang.Cs:
                foreach (GVar p in f.Params) ps.Add(TypeOf(L, p.T) + " " + p.Name);
                sig = "public static " + TypeOf(L, f.Ret) + " " + name + "(" + string.Join(", ", ps.ToArray()) + ")"; break;
            case Lang.Java:
                foreach (GVar p in f.Params) ps.Add(TypeOf(L, p.T) + " " + p.Name);
                sig = "public static " + TypeOf(L, f.Ret) + " " + name + "(" + string.Join(", ", ps.ToArray()) + ") {"; break;
            case Lang.Go:
                foreach (GVar p in f.Params) ps.Add(p.Name + " " + TypeOf(L, p.T));
                sig = "func " + name + "(" + string.Join(", ", ps.ToArray()) + ") " + TypeOf(L, f.Ret) + " {"; break;
            case Lang.Rust:
                foreach (GVar p in f.Params) ps.Add(p.Name + ": " + TypeOf(L, p.T));
                sig = "pub fn " + name + "(" + string.Join(", ", ps.ToArray()) + ") -> " + TypeOf(L, f.Ret) + " {"; break;
            default:
                foreach (GVar p in f.Params) ps.Add(TypeOf(L, p.T) + " " + p.Name);
                sig = "inline " + TypeOf(L, f.Ret) + " " + name + "(" + string.Join(", ", ps.ToArray()) + ") {"; break;
        }
        var lines = new List<string>();
        lines.Add(sig);
        if (L == Lang.Cs) lines.Add("{");
        Stmts(L, f.Body, "    ", "    ", lines);
        if (L != Lang.Py) lines.Add("}");
        return string.Join("\n", lines.ToArray());
    }
}


// ---------------------------------------------------------------------
//  Declarations (constants, enums, record types) and plain text files.
// ---------------------------------------------------------------------
class Chunk
{
    public string Code = "", Desc = "", Noun = "", Kind = "fn", Main = "";
    public List<string> Syms = new List<string>();
}

class TextFile
{
    public string Path = "", Kind = "", Noun = "", Table = "", Content = "", Desc = "";
}

static class Decls
{
    static readonly string[] ConstA = { "max", "min", "default", "base", "limit", "retry", "window", "step", "batch", "cache", "idle", "burst", "soft", "hard" };
    static readonly string[] ConstB = { "size", "count", "timeout", "ratio", "depth", "width", "span", "score", "level", "interval", "factor", "budget" };
    static readonly string[] StrVals = { "alpha", "primary", "standard", "legacy", "fallback", "staging", "local", "cached", "strict", "open", "latest", "stable" };
    static readonly string[] StrSuffix = { "", "-v2", "-edge", "-1" };
    static readonly string[] EnumKind = { "state", "status", "kind", "mode", "phase", "level", "class" };
    static readonly string[] EnumMem = { "pending", "active", "stale", "closed", "queued", "failed", "ready", "paused", "draft", "done", "new", "idle", "retry", "locked", "synced", "dropped" };
    static readonly string[] StructKind = { "record", "entry", "info", "options", "stats", "summary", "snapshot", "header" };
    static readonly string[] Field = { "count", "ratio", "label", "owner", "stamp", "size", "level", "limit", "mode", "score", "weight", "offset", "region", "token", "flag", "total", "rank" };

    static string Upper(IEnumerable<string> w)
    {
        var l = new List<string>();
        foreach (string s in w) l.Add(s.ToUpperInvariant());
        return string.Join("_", l.ToArray());
    }

    static string Snake(IEnumerable<string> w) { return string.Join("_", w); }

    static string ConstName(Lang L, string[] w) { return (L == Lang.Cs || L == Lang.Go) ? Nm.Pascal(w) : Upper(w); }

    static string FieldName(Lang L, string w)
    {
        if (L == Lang.Cs || L == Lang.Go) return Nm.Cap(w);
        return w;   // single lowercase word reads the same in camelCase and snake_case
    }

    static List<string> Sample(Random r, string[] src, int n)
    {
        var pool = new List<string>(src);
        var o = new List<string>();
        while (o.Count < n && pool.Count > 0) { int i = r.Next(pool.Count); o.Add(pool[i]); pool.RemoveAt(i); }
        return o;
    }

    public static Chunk MakeConsts(Random r, Lang L, string noun)
    {
        int n = r.Next(3, 6);
        var names = new List<string[]>(); var kinds = new List<char>(); var ivals = new List<double>(); var svals = new List<string>();
        var seen = new HashSet<string>();
        string[] kpool = { "i", "i", "i", "n", "s" };
        while (names.Count < n)
        {
            string b = r.Next(2) == 0 ? noun : ConstB[r.Next(ConstB.Length)];
            string[] w = { ConstA[r.Next(ConstA.Length)], b };
            if (w[0] == w[1]) continue;
            string key = w[0] + " " + w[1];
            if (!seen.Add(key)) continue;
            char k = kpool[r.Next(kpool.Length)][0];
            names.Add(w); kinds.Add(k);
            if (k == 'i') { ivals.Add(r.Next(1, 10000)); svals.Add(""); }
            else if (k == 'n') { ivals.Add(Math.Round(0.05 + r.NextDouble() * 98.95, 2)); svals.Add(""); }
            else { ivals.Add(0); svals.Add(StrVals[r.Next(StrVals.Length)] + StrSuffix[r.Next(StrSuffix.Length)]); }
        }
        var lines = new List<string>(); var c = new Chunk();
        for (int i = 0; i < names.Count; i++)
        {
            string nm = ConstName(L, names[i]);
            c.Syms.Add(nm);
            char k = kinds[i];
            string lit = k == 'i' ? Rx.Int(ivals[i]) : (k == 'n' ? Rx.Num(ivals[i]) : "\"" + svals[i] + "\"");
            switch (L)
            {
                case Lang.Py: lines.Add(nm + " = " + lit); break;
                case Lang.Js: case Lang.Ts: lines.Add("export const " + nm + " = " + lit + ";"); break;
                case Lang.Cs: lines.Add("public const " + (k == 'i' ? "long" : (k == 'n' ? "double" : "string")) + " " + nm + " = " + lit + ";"); break;
                case Lang.Java: lines.Add("public static final " + (k == 'i' ? "long" : (k == 'n' ? "double" : "String")) + " " + nm + " = " + (k == 'i' ? lit + "L" : lit) + ";"); break;
                case Lang.Go: lines.Add("const " + nm + " " + (k == 'i' ? "int64" : (k == 'n' ? "float64" : "string")) + " = " + lit); break;
                case Lang.Rust: lines.Add("pub const " + nm + ": " + (k == 'i' ? "i64" : (k == 'n' ? "f64" : "&str")) + " = " + lit + ";"); break;
                default: lines.Add("inline constexpr " + (k == 'i' ? "long long" : (k == 'n' ? "double" : "const char*")) + " " + nm + " = " + lit + ";"); break;
            }
        }
        c.Code = string.Join("\n", lines.ToArray());
        c.Desc = "define " + noun + " limits and defaults";
        c.Noun = noun; c.Kind = "const"; c.Main = c.Syms[0];
        return c;
    }

    public static Chunk MakeEnum(Random r, Lang L, string noun)
    {
        string[] nw = { noun, EnumKind[r.Next(EnumKind.Length)] };
        string T = Nm.Pascal(nw);
        List<string> mem = Sample(r, EnumMem, r.Next(3, 6));
        var lines = new List<string>(); var c = new Chunk();
        switch (L)
        {
            case Lang.Py:
                lines.Add("class " + T + ":");
                for (int i = 0; i < mem.Count; i++) lines.Add("    " + mem[i].ToUpperInvariant() + " = " + i);
                break;
            case Lang.Js:
                lines.Add("export const " + T + " = Object.freeze({");
                for (int i = 0; i < mem.Count; i++) lines.Add("  " + mem[i].ToUpperInvariant() + ": " + i + ",");
                lines.Add("});");
                break;
            case Lang.Ts:
                lines.Add("export enum " + T + " {");
                foreach (string m in mem) lines.Add("  " + Nm.Cap(m) + ",");
                lines.Add("}");
                break;
            case Lang.Cs:
                lines.Add("public enum " + T); lines.Add("{");
                foreach (string m in mem) lines.Add("    " + Nm.Cap(m) + ",");
                lines.Add("}");
                break;
            case Lang.Java:
                lines.Add("public enum " + T + " {");
                for (int i = 0; i < mem.Count; i++) lines.Add("    " + mem[i].ToUpperInvariant() + (i < mem.Count - 1 ? "," : ""));
                lines.Add("}");
                break;
            case Lang.Go:
                lines.Add("type " + T + " int"); lines.Add(""); lines.Add("const (");
                for (int i = 0; i < mem.Count; i++)
                {
                    string nm = T + Nm.Cap(mem[i]);
                    lines.Add(i == 0 ? "    " + nm + " " + T + " = iota" : "    " + nm);
                    c.Syms.Add(nm);
                }
                lines.Add(")");
                break;
            case Lang.Rust:
                lines.Add("#[derive(Debug, Clone, Copy, PartialEq, Eq)]"); lines.Add("pub enum " + T + " {");
                foreach (string m in mem) lines.Add("    " + Nm.Cap(m) + ",");
                lines.Add("}");
                break;
            default:
                lines.Add("enum class " + T + " {");
                foreach (string m in mem) lines.Add("    " + Nm.Cap(m) + ",");
                lines.Add("};");
                break;
        }
        c.Syms.Add(T);
        c.Code = string.Join("\n", lines.ToArray());
        c.Desc = "describe the " + noun + " " + nw[1] + " values";
        c.Noun = noun; c.Kind = "enum"; c.Main = T;
        return c;
    }

    public static Chunk MakeStruct(Random r, Lang L, string noun)
    {
        string[] nw = { noun, StructKind[r.Next(StructKind.Length)] };
        string T = Nm.Pascal(nw);
        List<string> fn = Sample(r, Field, r.Next(2, 5));
        char[] ft = new char[fn.Count];
        string kp = "iinsb";
        for (int i = 0; i < ft.Length; i++) ft[i] = kp[r.Next(kp.Length)];
        var lines = new List<string>(); var c = new Chunk();
        var args = new List<string>();
        foreach (string f in fn) args.Add(FieldName(L, f));
        switch (L)
        {
            case Lang.Py:
                lines.Add("class " + T + ":");
                lines.Add("    def __init__(self, " + string.Join(", ", args.ToArray()) + "):");
                foreach (string a in args) lines.Add("        self." + a + " = " + a);
                break;
            case Lang.Js:
                lines.Add("export class " + T + " {");
                lines.Add("  constructor(" + string.Join(", ", args.ToArray()) + ") {");
                foreach (string a in args) lines.Add("    this." + a + " = " + a + ";");
                lines.Add("  }"); lines.Add("}");
                break;
            case Lang.Ts:
                lines.Add("export interface " + T + " {");
                for (int i = 0; i < args.Count; i++) lines.Add("  " + args[i] + ": " + (ft[i] == 's' ? "string" : (ft[i] == 'b' ? "boolean" : "number")) + ";");
                lines.Add("}");
                break;
            case Lang.Cs:
                lines.Add("public sealed class " + T); lines.Add("{");
                for (int i = 0; i < args.Count; i++)
                    lines.Add("    public " + (ft[i] == 'i' ? "long" : (ft[i] == 'n' ? "double" : (ft[i] == 's' ? "string" : "bool"))) + " " + args[i] + " { get; set; }" + (ft[i] == 's' ? " = \"\";" : ""));
                lines.Add("}");
                break;
            case Lang.Java:
                lines.Add("public static class " + T + " {");
                for (int i = 0; i < args.Count; i++)
                    lines.Add("    public " + (ft[i] == 'i' ? "long" : (ft[i] == 'n' ? "double" : (ft[i] == 's' ? "String" : "boolean"))) + " " + args[i] + ";");
                lines.Add("}");
                break;
            case Lang.Go:
                lines.Add("type " + T + " struct {");
                for (int i = 0; i < args.Count; i++)
                    lines.Add("    " + args[i] + " " + (ft[i] == 'i' ? "int64" : (ft[i] == 'n' ? "float64" : (ft[i] == 's' ? "string" : "bool"))));
                lines.Add("}");
                break;
            case Lang.Rust:
                lines.Add("#[derive(Debug, Clone)]"); lines.Add("pub struct " + T + " {");
                for (int i = 0; i < args.Count; i++)
                    lines.Add("    pub " + args[i] + ": " + (ft[i] == 'i' ? "i64" : (ft[i] == 'n' ? "f64" : (ft[i] == 's' ? "String" : "bool"))) + ",");
                lines.Add("}");
                break;
            default:
                lines.Add("struct " + T + " {");
                for (int i = 0; i < args.Count; i++)
                    lines.Add("    " + (ft[i] == 'i' ? "long long" : (ft[i] == 'n' ? "double" : (ft[i] == 's' ? "std::string" : "bool"))) + " " + args[i] +
                              (ft[i] == 'i' ? " = 0;" : (ft[i] == 'n' ? " = 0.0;" : (ft[i] == 's' ? ";" : " = false;"))));
                lines.Add("};");
                break;
        }
        c.Syms.Add(T);
        c.Code = string.Join("\n", lines.ToArray());
        c.Desc = "hold a " + noun + " " + nw[1];
        c.Noun = noun; c.Kind = "struct"; c.Main = T;
        return c;
    }
}

class JN
{
    public char K;           // o object, a array, s string, i int, f float, b bool
    public double V; public string S = "";
    public List<string> Keys = new List<string>();
    public List<JN> Items = new List<JN>();
}

static class TextGen
{
    static readonly string[] KeysA = { "max", "min", "default", "retry", "cache", "batch", "idle", "burst", "soft", "hard", "base", "poll", "flush", "sync", "warm" };
    static readonly string[] KeysB = { "timeout", "retries", "size", "interval", "limit", "depth", "threshold", "ttl", "ratio", "delay", "capacity", "window" };
    static readonly string[] Units = { "", "", "_ms", "_s", "_pct", "_count" };
    static readonly string[] Strs = { "primary", "standard", "legacy", "fallback", "staging", "local", "cached", "strict", "open", "latest", "stable", "eu-west", "blue", "green", "edge" };
    static readonly string[] Flags = { "enabled", "verbose", "strict", "dry_run", "compress", "audit", "readonly", "persist" };
    static readonly string[] SqlKind = { "records", "entries", "events", "items", "logs", "snapshots" };
    static readonly string[][] Cols =
    {
        new string[] { "owner", "TEXT NOT NULL" }, new string[] { "label", "TEXT" }, new string[] { "count", "INTEGER NOT NULL DEFAULT 0" },
        new string[] { "ratio", "REAL" }, new string[] { "level", "INTEGER" }, new string[] { "region", "TEXT" },
        new string[] { "score", "REAL NOT NULL DEFAULT 0" }, new string[] { "state", "TEXT NOT NULL DEFAULT 'new'" },
        new string[] { "created_at", "TIMESTAMP" }, new string[] { "active", "INTEGER NOT NULL DEFAULT 1" },
        new string[] { "weight", "REAL" }, new string[] { "token", "TEXT" }, new string[] { "rank", "INTEGER" }
    };
    static readonly string[] Verbs = { "sync", "check", "rotate", "export", "report", "prune", "verify", "seed", "scan", "summarize" };
    static readonly string[] Sent =
    {
        "The {a} module keeps {b} values in sync with the {c} cache.",
        "Each {a} is validated before it reaches the {b} queue.",
        "Use {a} settings to tune how often {b} data is refreshed.",
        "A {a} that stays idle for too long is moved to the {b} list.",
        "The {a} helpers are pure functions, so they are safe to call from any thread.",
        "When a {a} fails, the {b} handler retries a few times before giving up.",
        "Keep {a} and {b} names short and lowercase.",
        "The {c} report groups every {a} by {b}.",
        "Defaults for {a} live in the config folder and can be overridden per environment.",
        "Run the {a} check before changing any {b} limits."
    };
    static readonly string[] Bullet =
    {
        "Validate {a} input early", "Keep {b} values small", "Prefer {c} defaults", "Log every {a} change", "Document new {b} fields", "Review {c} limits each release"
    };
    public static readonly string[] Kinds = { "json", "json", "yaml", "yaml", "env", "sql", "sql", "csv", "sh", "sh", "md", "md" };

    static string Pk(Random r, string[] a) { return a[r.Next(a.Length)]; }

    static JN GenNode(Random r, List<string> nouns, int depth)
    {
        var opts = new List<char> { 'i', 'i', 'f', 'b', 's', 's', 'a' };
        if (depth > 0) opts.Add('o');
        char k = opts[r.Next(opts.Count)];
        JN n = new JN(); n.K = k;
        if (k == 'i')
        {
            int t = r.Next(3);
            int[] common = { 30, 60, 100, 250, 500, 1024 };
            n.V = t == 0 ? r.Next(1, 101) : (t == 1 ? r.Next(100, 10000) : common[r.Next(common.Length)]);
        }
        else if (k == 'f') n.V = Math.Round(0.01 + r.NextDouble() * 98.99, 2);
        else if (k == 'b') n.V = r.Next(2);
        else if (k == 's') n.S = Pk(r, Strs);
        else if (k == 'a')
        {
            bool ints = r.Next(2) == 0;
            int cnt = r.Next(2, 5);
            for (int i = 0; i < cnt; i++)
            {
                JN x = new JN();
                if (ints) { x.K = 'i'; x.V = r.Next(1, 501); } else { x.K = 's'; x.S = Pk(r, Strs); }
                n.Items.Add(x);
            }
        }
        else return GenObj(r, nouns, depth - 1);
        return n;
    }

    static JN GenObj(Random r, List<string> nouns, int depth)
    {
        JN o = new JN(); o.K = 'o';
        int n = r.Next(3, 7);
        while (o.Keys.Count < n)
        {
            double c = r.NextDouble();
            string key = c < 0.55 ? Pk(r, KeysA) + "_" + Pk(r, KeysB) + Pk(r, Units)
                       : (c < 0.75 ? Pk(r, Flags) : nouns[r.Next(nouns.Count)] + "_" + Pk(r, KeysB));
            if (o.Keys.Contains(key)) continue;
            o.Keys.Add(key); o.Items.Add(GenNode(r, nouns, depth));
        }
        return o;
    }

    static string Scalar(JN v)
    {
        if (v.K == 's') return v.S;
        if (v.K == 'b') return v.V != 0 ? "true" : "false";
        return v.K == 'i' ? Rx.Int(v.V) : Rx.Num(v.V);
    }

    static string JsonW(JN n, int ind)
    {
        string p = new string(' ', ind * 2);
        if (n.K == 'o')
        {
            var parts = new List<string>();
            for (int i = 0; i < n.Keys.Count; i++) parts.Add(p + "  \"" + n.Keys[i] + "\": " + JsonW(n.Items[i], ind + 1));
            return "{\n" + string.Join(",\n", parts.ToArray()) + "\n" + p + "}";
        }
        if (n.K == 'a')
        {
            var parts = new List<string>();
            foreach (JN x in n.Items) parts.Add(JsonW(x, ind));
            return "[" + string.Join(", ", parts.ToArray()) + "]";
        }
        if (n.K == 's') return "\"" + n.S + "\"";
        return Scalar(n);
    }

    static void YamlW(JN n, int ind, List<string> o)
    {
        string p = new string(' ', ind * 2);
        for (int i = 0; i < n.Keys.Count; i++)
        {
            JN v = n.Items[i];
            if (v.K == 'o') { o.Add(p + n.Keys[i] + ":"); YamlW(v, ind + 1, o); }
            else if (v.K == 'a')
            {
                o.Add(p + n.Keys[i] + ":");
                foreach (JN x in v.Items) o.Add(p + "  - " + Scalar(x));
            }
            else o.Add(p + n.Keys[i] + ": " + Scalar(v));
        }
    }

    static string Fill(string s, Random r, List<string> nouns)
    {
        return s.Replace("{a}", nouns[r.Next(nouns.Count)]).Replace("{b}", nouns[r.Next(nouns.Count)]).Replace("{c}", nouns[r.Next(nouns.Count)]);
    }

    // Builds the content of a text file of the given kind. For sql the table name is fixed by tf.Table.
    public static void Fillin(Random r, TextFile tf, List<string> nouns)
    {
        string noun = tf.Noun;
        switch (tf.Kind)
        {
            case "json": tf.Content = JsonW(GenObj(r, nouns, 2), 0) + "\n"; tf.Desc = "settings"; break;
            case "yaml":
            {
                var o = new List<string>(); o.Add("# " + noun + " settings");
                YamlW(GenObj(r, nouns, 2), 0, o);
                tf.Content = string.Join("\n", o.ToArray()) + "\n"; tf.Desc = "settings"; break;
            }
            case "env":
            {
                JN obj = GenObj(r, nouns, 0); var lines = new List<string>();
                for (int i = 0; i < obj.Keys.Count; i++) lines.Add(noun.ToUpperInvariant() + "_" + obj.Keys[i].ToUpperInvariant() + "=" + Scalar(obj.Items[i]));
                if (lines.Count < 2) lines.Add(noun.ToUpperInvariant() + "_MODE=" + Pk(r, Strs));
                tf.Content = string.Join("\n", lines.ToArray()) + "\n"; tf.Desc = "environment defaults"; break;
            }
            case "sql": Sql(r, tf); break;
            case "csv": Csv(r, tf); break;
            case "sh": Sh(r, tf); break;
            default:
            {
                var paras = new List<string>();
                int np = r.Next(1, 3);
                for (int i = 0; i < np; i++)
                {
                    var ls = new List<string>(); int ns = r.Next(2, 4);
                    for (int j = 0; j < ns; j++) ls.Add(Fill(Pk(r, Sent), r, nouns));
                    paras.Add(string.Join("\n", ls.ToArray()));
                }
                var pool = new List<string>(Bullet); var bl = new List<string>(); int nb = r.Next(3, 5);
                while (bl.Count < nb) { int ix = r.Next(pool.Count); bl.Add("- " + Fill(pool[ix], r, nouns)); pool.RemoveAt(ix); }
                tf.Content = "# " + Nm.Cap(noun) + " notes\n\n" + string.Join("\n\n", paras.ToArray()) + "\n\n## Guidelines\n\n" + string.Join("\n", bl.ToArray()) + "\n";
                tf.Desc = "notes"; break;
            }
        }
    }

    static void Sql(Random r, TextFile tf)
    {
        string t = tf.Table;
        var pool = new List<string[]>(Cols); var cols = new List<string[]>();
        int nc = r.Next(3, 6);
        while (cols.Count < nc) { int ix = r.Next(pool.Count); cols.Add(pool[ix]); pool.RemoveAt(ix); }
        var o = new List<string>();
        o.Add("-- Create the " + t + " table.");
        o.Add("CREATE TABLE IF NOT EXISTS " + t + " (");
        o.Add("    id INTEGER PRIMARY KEY,");
        for (int i = 0; i < cols.Count; i++) o.Add("    " + cols[i][0] + " " + cols[i][1] + (i < cols.Count - 1 ? "," : ""));
        o.Add(");"); o.Add("");
        string ic = cols[r.Next(cols.Count)][0];
        o.Add("CREATE INDEX IF NOT EXISTS idx_" + t + "_" + ic + " ON " + t + " (" + ic + ");");
        if (r.Next(2) == 0)
        {
            o.Add("");
            var simple = new List<string[]>();
            foreach (string[] c in cols) if (c[1].IndexOf("TIMESTAMP") < 0) simple.Add(c);
            var names = new List<string>();
            foreach (string[] c in simple) names.Add(c[0]);
            int rows = r.Next(1, 4);
            for (int q = 0; q < rows; q++)
            {
                var vals = new List<string>();
                foreach (string[] c in simple)
                {
                    if (c[1].StartsWith("TEXT")) vals.Add("'" + Pk(r, Strs) + "'");
                    else if (c[1].StartsWith("REAL")) vals.Add(Rx.Num(Math.Round(r.NextDouble() * 99, 2)));
                    else vals.Add(r.Next(0, 100).ToString());
                }
                o.Add("INSERT INTO " + t + " (" + string.Join(", ", names.ToArray()) + ") VALUES (" + string.Join(", ", vals.ToArray()) + ");");
            }
        }
        tf.Content = string.Join("\n", o.ToArray()) + "\n"; tf.Desc = "table";
    }

    static void Csv(Random r, TextFile tf)
    {
        var pool = new List<string[]>(Cols); var names = new List<string>(); names.Add("id");
        int nc = r.Next(2, 5);
        for (int i = 0; i < nc; i++)
        {
            int ix = r.Next(pool.Count); string n = pool[ix][0]; pool.RemoveAt(ix);
            if (n != "created_at") names.Add(n);
        }
        var o = new List<string>(); o.Add(string.Join(",", names.ToArray()));
        int rows = r.Next(6, 14);
        for (int i = 1; i < rows; i++)
        {
            var row = new List<string>(); row.Add(i.ToString());
            for (int j = 1; j < names.Count; j++)
            {
                double c = r.NextDouble();
                row.Add(c < 0.3 ? Pk(r, Strs) : (c < 0.6 ? Rx.Num(Math.Round(r.NextDouble() * 99, 2)) : r.Next(0, 1000).ToString()));
            }
            o.Add(string.Join(",", row.ToArray()));
        }
        tf.Content = string.Join("\n", o.ToArray()) + "\n"; tf.Desc = "sample data";
    }

    static void Sh(Random r, TextFile tf)
    {
        string N = tf.Noun.ToUpperInvariant();
        var blocks = new List<string>();
        blocks.Add("N_LIMIT=" + r.Next(5, 501) + "\nlog \"limit is ${N_LIMIT}\"");
        var items = new List<string>(Strs); var pick = new List<string>(); int ni = r.Next(2, 5);
        while (pick.Count < ni) { int ix = r.Next(items.Count); pick.Add(items[ix]); items.RemoveAt(ix); }
        blocks.Add("for item in " + string.Join(" ", pick.ToArray()) + "; do\n    log \"checking ${item}\"\ndone");
        blocks.Add("total=0\nfor i in $(seq 1 " + r.Next(3, 13) + "); do\n    total=$((total + i * " + r.Next(1, 6) + "))\ndone\nlog \"total ${total}\"");
        blocks.Add("count=0\nwhile [ \"${count}\" -lt " + r.Next(2, 10) + " ]; do\n    count=$((count + 1))\ndone\nlog \"ran ${count} rounds\"");
        blocks.Add("mode=\"${1:-" + Pk(r, Strs) + "}\"\ncase \"${mode}\" in\n    " + Pk(r, Strs) + ")\n        log \"fast path\"\n        ;;\n    *)\n        log \"default path for ${mode}\"\n        ;;\nesac");
        for (int i = 0; i < blocks.Count; i++) blocks[i] = blocks[i].Replace("N_LIMIT", N + "_LIMIT");
        string first = "log() {\n    printf '%s\\n' \"$*\"\n}";
        var rest = new List<string>(blocks);
        int take = r.Next(2, 4); var chosen = new List<string>(); chosen.Add(first);
        while (chosen.Count < take + 1 && rest.Count > 0) { int ix = r.Next(rest.Count); chosen.Add(rest[ix]); rest.RemoveAt(ix); }
        tf.Content = "#!/usr/bin/env bash\n# " + Nm.Cap(tf.Table) + " the " + tf.Noun + " data.\nset -eu\n\n" + string.Join("\n\n", chosen.ToArray()) + "\n";
        tf.Desc = "helper script";
    }

    // Creates the descriptor (path, table) for a new text file; the content comes from Fillin.
    public static TextFile Create(Random r, string kind, string noun, int seq)
    {
        TextFile tf = new TextFile(); tf.Kind = kind; tf.Noun = noun;
        switch (kind)
        {
            case "json": tf.Path = "config/" + noun + ".json"; break;
            case "yaml": tf.Path = "config/" + noun + ".yaml"; break;
            case "env": tf.Path = "config/" + noun + ".env.example"; break;
            case "sql":
                tf.Table = noun + "_" + Pk(r, SqlKind);
                tf.Path = "db/migrations/" + seq.ToString("000") + "_create_" + tf.Table + ".sql"; break;
            case "csv": tf.Path = "data/" + noun + ".csv"; break;
            case "sh":
                tf.Table = Pk(r, Verbs);   // verb used in the script name and header
                tf.Path = "scripts/" + tf.Table + "-" + noun + ".sh"; break;
            default: tf.Path = "docs/" + noun + "-notes.md"; break;
        }
        return tf;
    }
}


static class RepoScanner
{
    static readonly Dictionary<string, Lang> ExtLang = new Dictionary<string, Lang>
    {
        { "py", Lang.Py }, { "js", Lang.Js }, { "mjs", Lang.Js }, { "cjs", Lang.Js }, { "jsx", Lang.Js },
        { "ts", Lang.Ts }, { "tsx", Lang.Ts }, { "cs", Lang.Cs }, { "java", Lang.Java }, { "go", Lang.Go },
        { "rs", Lang.Rust }, { "cpp", Lang.Cpp }, { "cc", Lang.Cpp }, { "cxx", Lang.Cpp }, { "hpp", Lang.Cpp },
        { "h", Lang.Cpp }, { "c", Lang.Cpp }
    };

    static readonly HashSet<string> NoiseDirs = new HashSet<string>(
        "node_modules vendor dist build bin obj target .git .github third_party external __pycache__ .venv venv .idea .vs".Split(' '));
    static readonly HashSet<string> TestishDirs = new HashSet<string>(
        "test tests spec specs docs doc example examples samples scripts".Split(' '));

    static int Hash(string s)
    {
        unchecked
        {
            uint h = 2166136261u;
            foreach (char c in s) { h ^= c; h *= 16777619u; }
            return (int)(h % 1000003u);
        }
    }

    static bool GoodWord(string w, int minLen)
    {
        return w.Length >= minLen && w.Length <= 12 && !Vocab.Reserved.Contains(w);
    }

    public static RepoProfile Scan(string[] paths, string readme, string repo, bool empty)
    {
        var p = new RepoProfile();
        p.Slug = repo; p.Empty = empty;
        p.Title = Nm.Cap(repo.Replace('-', ' ').Replace('_', ' ').Replace('.', ' ').Trim());
        if (p.Title.Length == 0) p.Title = "Project";

        var langCount = new Dictionary<Lang, int>();
        var perDir = new Dictionary<Lang, Dictionary<string, int>>();
        var wordCount = new Dictionary<string, int>();
        int seen = 0;

        foreach (string path in paths)
        {
            p.Paths.Add(path);
            string[] seg = path.Split('/');
            string acc = "";
            bool noise = false, testish = false;
            for (int i = 0; i < seg.Length - 1; i++)
            {
                acc = acc.Length == 0 ? seg[i] : acc + "/" + seg[i];
                p.Dirs.Add(acc);
                if (NoiseDirs.Contains(seg[i])) noise = true;
                if (TestishDirs.Contains(seg[i].ToLowerInvariant())) testish = true;
            }
            string file = seg[seg.Length - 1];
            int dot = file.LastIndexOf('.');
            string stem = dot > 0 ? file.Substring(0, dot) : file;
            p.Stems.Add(stem.ToLowerInvariant().Replace("_", "").Replace("-", ""));
            if (noise || ++seen > 20000) continue;

            Lang l;
            string ext = dot >= 0 ? file.Substring(dot + 1).ToLowerInvariant() : "";
            if (ExtLang.TryGetValue(ext, out l))
            {
                int n;
                langCount.TryGetValue(l, out n);
                langCount[l] = n + 1;
                if (!testish)
                {
                    Dictionary<string, int> dc;
                    if (!perDir.TryGetValue(l, out dc)) { dc = new Dictionary<string, int>(); perDir[l] = dc; }
                    int k;
                    dc.TryGetValue(acc, out k);
                    dc[acc] = k + 1;
                }
            }

            for (int i = 0; i < seg.Length; i++)
            {
                string part = i == seg.Length - 1 ? stem : seg[i];
                foreach (string w in Nm.Words(part))
                {
                    if (!GoodWord(w, 4) || Vocab.Stop.Contains(w)) continue;
                    int c;
                    wordCount.TryGetValue(w, out c);
                    wordCount[w] = c + 1;
                }
            }
        }

        // Language: whatever the repo is mostly written in; stable pick from the repo name otherwise.
        int bestLang = 0; bool found = false;
        foreach (KeyValuePair<Lang, int> kv in langCount)
        {
            if (!found || kv.Value > bestLang || (kv.Value == bestLang && kv.Key < p.Lang))
            {
                p.Lang = kv.Key; bestLang = kv.Value; found = true;
            }
        }
        if (!found)
        {
            Lang[] fallback = { Lang.Py, Lang.Js, Lang.Ts, Lang.Cs, Lang.Go, Lang.Rust };
            p.Lang = fallback[Hash(repo) % fallback.Length];
        }

        // Source folder: the folder that already holds most files of that language.
        string best = null; int bestN = 0;
        Dictionary<string, int> dirs;
        if (perDir.TryGetValue(p.Lang, out dirs))
        {
            foreach (KeyValuePair<string, int> kv in dirs)
            {
                bool better = kv.Value > bestN;
                if (!better && kv.Value == bestN && best != null)
                    better = kv.Key.Length < best.Length || (kv.Key.Length == best.Length && string.CompareOrdinal(kv.Key, best) < 0);
                if (better) { best = kv.Key; bestN = kv.Value; }
            }
        }
        string sd = null;
        if (p.Lang == Lang.Go) sd = p.Dirs.Contains("pkg") ? "pkg" : "internal";
        else if (best != null && best.Length > 0) sd = best;
        else
        {
            foreach (string c in new string[] { "src", "lib", "app", "source", "pkg", "internal" })
                if (p.Dirs.Contains(c)) { sd = c; break; }
            if (sd == null)
            {
                string snake = string.Join("_", Nm.Words(repo).ToArray());
                sd = (p.Lang == Lang.Py && snake.Length > 0) ? snake : "src";
            }
        }
        if (!Regex.IsMatch(sd, "^[A-Za-z0-9_./-]+$") || sd.Contains("..") || sd.StartsWith("/")) sd = "src";
        p.SrcDir = sd.TrimEnd('/');
        if (p.Lang == Lang.Java)
        {
            int ix = p.SrcDir.IndexOf("/java/");
            if (ix >= 0) p.JavaRoot = p.SrcDir.Substring(0, ix + 5);
            else if (p.SrcDir == "java" || p.SrcDir.EndsWith("/java")) p.JavaRoot = p.SrcDir;
            else if (p.SrcDir.StartsWith("java/")) p.JavaRoot = "java";
        }

        // Vocabulary: repo name first, then words that recur in file/folder names, then the README.
        var ordered = new List<KeyValuePair<string, int>>(wordCount);
        ordered.Sort(delegate (KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            int c = b.Value.CompareTo(a.Value);
            return c != 0 ? c : string.CompareOrdinal(a.Key, b.Key);
        });
        var nouns = new List<string>();
        foreach (string w in Nm.Words(repo))
            if (GoodWord(w, 3) && !nouns.Contains(w)) nouns.Add(w);
        for (int i = 0; i < ordered.Count && nouns.Count < 30; i++)
            if (!nouns.Contains(ordered[i].Key)) nouns.Add(ordered[i].Key);

        var rc = new Dictionary<string, int>();
        foreach (Match m in Regex.Matches(readme ?? "", "[A-Za-z]{5,10}"))
        {
            string w = m.Value.ToLowerInvariant();
            if (Vocab.Stop.Contains(w) || Vocab.Filler.Contains(w) || Vocab.Reserved.Contains(w)) continue;
            int c;
            rc.TryGetValue(w, out c);
            rc[w] = c + 1;
        }
        var rl = new List<KeyValuePair<string, int>>(rc);
        rl.Sort(delegate (KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            int c = b.Value.CompareTo(a.Value);
            return c != 0 ? c : string.CompareOrdinal(a.Key, b.Key);
        });
        for (int i = 0; i < rl.Count && i < 8; i++)
            if (!nouns.Contains(rl[i].Key)) nouns.Add(rl[i].Key);

        foreach (string w in Vocab.Defaults)
        {
            if (nouns.Count >= 40) break;
            if (!nouns.Contains(w) && GoodWord(w, 3)) nouns.Add(w);
        }
        p.Nouns = nouns;
        return p;
    }
}

class ContentGen
{
    readonly RepoProfile p;
    readonly Random rnd;
    readonly HashSet<string> usedPaths, usedStems, dirsKnown;
    readonly List<GenFile> live = new List<GenFile>();
    readonly List<TextFile> texts = new List<TextFile>();
    static readonly string[] Suffixes = { "utils", "helpers", "core", "format", "checks", "stats", "tools", "metrics", "support" };
    // The working set is bounded on purpose: git rewrites every folder listing on every commit, so an ever-growing
    // set of files would make big runs quadratically slow and bloat the repo. Once the limits are reached, existing
    // generated files are edited instead (one piece of a file is swapped for a new one, or a text file is rewritten).
    const int MaxModules = 64;
    const int MaxTexts = 24;
    const int FilesPerDir = 16;
    readonly double fileChance;
    GenFile cur;
    bool first = true;
    int flatCount, groupCount, seq, sqlSeq = 1;
    string groupDir;

    // fileChance: share of commits that change a file (the others are message-only commits).
    public ContentGen(RepoProfile profile, Random random, double fileChance)
    {
        p = profile; rnd = random; this.fileChance = fileChance;
        usedPaths = new HashSet<string>(p.Paths);
        usedStems = new HashSet<string>(p.Stems);
        dirsKnown = new HashSet<string>(p.Dirs);
    }

    public CommitPlan Next()
    {
        var plan = new CommitPlan();
        if (first)
        {
            first = false;
            if (p.Empty) { Initial(plan); return plan; }
        }
        if (rnd.NextDouble() >= fileChance) { Chore(plan); return plan; }

        double r = rnd.NextDouble();
        if (live.Count < MaxModules && (cur == null || cur.Full || r < 0.08))
        {
            if (NewModule(plan)) return plan;
        }
        else if (r < 0.30 && TextCommit(plan)) return plan;
        if (Evolve(plan)) return plan;
        if (TextCommit(plan)) return plan;
        Chore(plan);
        return plan;
    }

    // ----- picking -----
    string PickNoun() { return p.Nouns[rnd.Next(p.Nouns.Count)]; }

    string IndentFor()
    {
        if (p.Lang == Lang.Cs) return "        ";
        if (p.Lang == Lang.Java) return "    ";
        return "";
    }

    bool PathOk(string path)
    {
        if (usedPaths.Contains(path) || dirsKnown.Contains(path)) return false;
        int i = path.IndexOf('/');
        while (i >= 0)
        {
            if (usedPaths.Contains(path.Substring(0, i))) return false;
            i = path.IndexOf('/', i + 1);
        }
        return true;
    }

    void AddDirs(string path)
    {
        int i = path.IndexOf('/');
        while (i >= 0) { dirsKnown.Add(path.Substring(0, i)); i = path.IndexOf('/', i + 1); }
    }

    // Builds one new piece for a code file: a function (most of the time), a block of constants, an enum or a record type.
    Chunk MakeChunk(GenFile g)
    {
        for (int t = 0; t < 25; t++)
        {
            string noun = PickNoun();
            int k = rnd.Next(100);
            Chunk c;
            string name;
            if (k < 66)
            {
                string n2 = noun;
                if (rnd.Next(100) < 25) { string x = PickNoun(); if (x != noun) n2 = noun + " " + x; }
                GFn f = Families.Make(rnd, n2);
                var words = new List<string>();
                foreach (string w in f.Words) words.AddRange(w.Split(' '));
                f.Words = words;
                name = Nm.FnName(p.Lang, words);
                c = new Chunk();
                c.Code = FnRender.Render(p.Lang, f, name);
                c.Desc = f.Desc; c.Noun = n2; c.Kind = "fn"; c.Main = name; c.Syms.Add(name);
            }
            else if (k < 78) c = Decls.MakeConsts(rnd, p.Lang, noun);
            else if (k < 89) c = Decls.MakeEnum(rnd, p.Lang, noun);
            else c = Decls.MakeStruct(rnd, p.Lang, noun);
            bool clash = false;
            foreach (string s in c.Syms) if (g.Names.Contains(s)) clash = true;
            if (clash) continue;
            string code = Nm.DocComment(p.Lang, c.Main, c.Desc, c.Code);
            if (p.Lang == Lang.Go) code = Nm.Tabs(code);
            c.Code = Nm.Indent(code, IndentFor());
            return c;
        }
        return null;
    }

    // ----- commit kinds -----
    bool Evolve(CommitPlan plan)
    {
        if (live.Count == 0) return false;
        GenFile g = (cur != null && !cur.Full && rnd.Next(10) < 7) ? cur : live[rnd.Next(live.Count)];
        Chunk old = null;
        int idx = -1;
        if (g.Full)
        {
            idx = rnd.Next(g.Items.Count);
            old = g.RemoveAt(idx);
        }
        Chunk m = MakeChunk(g);
        if (m == null)
        {
            if (old != null) g.Insert(idx, old);
            return false;
        }
        if (idx >= 0) g.Insert(idx, m); else g.Add(m);
        cur = g;
        plan.Add(g.Path, g.Content());
        plan.Message = old != null && rnd.Next(100) < 55 ? SwapMessage(g, old, m) : AddMessage(g, m);
        return true;
    }

    bool NewModule(CommitPlan plan)
    {
        List<string> words = null;
        string lower = null;
        for (int tries = 0; ; tries++)
        {
            words = new List<string>();
            words.Add(PickNoun());
            // Python modules always get a suffix so they can never shadow a standard-library module (queue.py, token.py, ...).
            if (rnd.Next(2) == 0 || p.Lang == Lang.Py) words.Add(Suffixes[rnd.Next(Suffixes.Length)]);
            if (tries >= 10) words.Add(PickNoun());
            if (tries >= 30) words.Add("v" + (++seq));
            lower = string.Join("", words.ToArray());
            if (Vocab.Reserved.Contains(lower) || usedStems.Contains(lower)) continue;
            break;
        }
        usedStems.Add(lower);

        string dir = ChooseDir(lower);
        string stem = Nm.StemFor(p.Lang, words);
        string path = Nm.Combine(dir, stem + Nm.Ext(p.Lang));
        if (p.Lang == Lang.Py && !dirsKnown.Contains(dir))
        {
            plan.Add(Nm.Combine(dir, "__init__.py"), "");
            usedPaths.Add(Nm.Combine(dir, "__init__.py"));
        }
        dirsKnown.Add(dir);
        usedPaths.Add(path);

        var g = new GenFile();
        g.Path = path;
        g.Slug = string.Join("-", words.ToArray());
        g.Title = Nm.Cap(string.Join(" ", words.ToArray()));
        g.Max = 3 + rnd.Next(4);
        InitModule(g, words, stem, lower, dir);

        Chunk m = null;
        for (int t = 0; t < 10 && m == null; t++) m = MakeChunk(g);
        if (m == null) return false;
        g.Add(m);
        live.Add(g);
        cur = g;
        plan.Add(path, g.Content());
        plan.Message = ModuleMessage(g, m);
        return true;
    }

    bool TextCommit(CommitPlan plan)
    {
        if (texts.Count < MaxTexts && (texts.Count == 0 || rnd.Next(100) < 40))
        {
            for (int t = 0; t < 20; t++)
            {
                string kind = TextGen.Kinds[rnd.Next(TextGen.Kinds.Length)];
                TextFile tf = TextGen.Create(rnd, kind, PickNoun(), sqlSeq);
                if (!PathOk(tf.Path)) continue;
                if (kind == "sql") sqlSeq++;
                TextGen.Fillin(rnd, tf, p.Nouns);
                texts.Add(tf);
                usedPaths.Add(tf.Path);
                AddDirs(tf.Path);
                plan.Add(tf.Path, tf.Content);
                plan.Message = TextNewMessage(tf);
                return true;
            }
        }
        if (texts.Count == 0) return false;
        TextFile e = texts[rnd.Next(texts.Count)];
        TextGen.Fillin(rnd, e, p.Nouns);
        plan.Add(e.Path, e.Content);
        plan.Message = TextEditMessage(e);
        return true;
    }

    void Initial(CommitPlan plan)
    {
        string desc = "Small helpers for " + p.Nouns[0] + ", " + p.Nouns[1] + " and " + p.Nouns[2] + " handling.";
        string readme = "# " + p.Title + "\n\n" + desc + "\n\n## Layout\n\n- `" + p.SrcDir + "/` source files\n- `config/` settings\n- `docs/` notes\n\n" +
                        "## Getting started\n\nClone the repository and open it in your editor.\n";
        plan.Add("README.md", readme);
        plan.Add(".gitignore", IgnoreText());
        usedPaths.Add("README.md");
        usedPaths.Add(".gitignore");
        switch (rnd.Next(4))
        {
            case 0: case 1: plan.Message = "Initial commit"; break;
            case 2: plan.Message = "chore: initial commit"; break;
            default: plan.Message = "chore: bootstrap " + p.Slug; break;
        }
    }

    string IgnoreText()
    {
        switch (p.Lang)
        {
            case Lang.Py: return "__pycache__/\n*.pyc\n.venv/\n";
            case Lang.Js: case Lang.Ts: return "node_modules/\ndist/\n";
            case Lang.Cs: return "bin/\nobj/\n.vs/\n";
            case Lang.Java: return "target/\n*.class\n";
            case Lang.Go: return "*.exe\n*.test\n";
            case Lang.Rust: return "target/\n";
            default: return "build/\n*.o\n";
        }
    }

    // ----- layout -----
    string ChooseDir(string lower)
    {
        if (p.Lang == Lang.Go) return Nm.Combine(p.SrcDir, lower);
        if (flatCount < FilesPerDir) { flatCount++; return p.SrcDir; }
        if (groupDir == null || groupCount >= FilesPerDir)
        {
            for (int t = 0; ; t++)
            {
                string g = PickNoun();
                if (t >= 15) g += (++seq).ToString();
                string d = Nm.Combine(p.SrcDir, g);
                if (Vocab.Reserved.Contains(g) || dirsKnown.Contains(d)) continue;
                groupDir = d; groupCount = 0;
                break;
            }
        }
        groupCount++;
        return groupDir;
    }

    string PackageFor(string dir)
    {
        if (p.JavaRoot == null || dir == p.JavaRoot || !dir.StartsWith(p.JavaRoot + "/")) return null;
        string pkg = dir.Substring(p.JavaRoot.Length + 1).Replace('/', '.');
        return Regex.IsMatch(pkg, "^[A-Za-z0-9_.]+$") ? pkg : null;
    }

    void InitModule(GenFile g, List<string> words, string stem, string lower, string dir)
    {
        string title = g.Title;
        switch (p.Lang)
        {
            case Lang.Py:
                g.Header = "\"\"\"" + title + " helpers.\"\"\"\n\n\n";
                g.Sep = "\n\n\n";
                break;
            case Lang.Js: case Lang.Ts:
                g.Header = "// " + title + " helpers.\n\n";
                break;
            case Lang.Cs:
                g.Header = "using System;\n\nnamespace Common.Utilities\n{\n    /// <summary>" + title + " helpers.</summary>\n    public static class " + stem + "\n    {\n";
                g.Footer = "    }\n}\n";
                break;
            case Lang.Java:
            {
                string pkg = PackageFor(dir);
                g.Header = (pkg != null ? "package " + pkg + ";\n\n" : "") + "/** " + title + " helpers. */\npublic final class " + stem +
                           " {\n    private " + stem + "() {\n    }\n\n";
                g.Footer = "}\n";
                break;
            }
            case Lang.Go:
                g.Header = "package " + lower + "\n\n";
                break;
            case Lang.Rust:
                g.Header = "//! " + title + " helpers.\n\n";
                break;
            default:
            {
                string ns = string.Join("_", words.ToArray());
                g.Header = "#pragma once\n\n#include <algorithm>\n#include <cctype>\n#include <cmath>\n#include <cstddef>\n#include <string>\n#include <utility>\n#include <vector>\n\nnamespace " + ns + " {\n\n";
                g.Footer = "\n}  // namespace " + ns + "\n";
                break;
            }
        }
    }

    // ----- commit messages -----
    string Compose(string type, string scope, string subject, string plainExtra)
    {
        double r = rnd.NextDouble();
        if (r < 0.55) return type + "(" + scope + "): " + subject;
        if (r < 0.72) return type + ": " + subject;
        return Nm.Cap(subject) + plainExtra;
    }

    string AddMessage(GenFile g, Chunk m)
    {
        string scope = g.Slug, type = "feat", subj;
        string name = m.Main;
        if (m.Kind == "fn")
        {
            if (rnd.Next(100) < 12)
            {
                type = "refactor";
                subj = rnd.Next(2) == 0 ? "extract " + name + " helper" : "move " + name + " into " + scope;
            }
            else
            {
                switch (rnd.Next(6))
                {
                    case 0: subj = "add " + name; break;
                    case 1: subj = "add " + name + " helper"; break;
                    case 2: subj = "implement " + name; break;
                    case 3: subj = "introduce " + name + " for " + m.Noun + " handling"; break;
                    case 4: subj = m.Desc; break;
                    default: subj = "add " + name + " to " + scope; break;
                }
            }
        }
        else if (m.Kind == "const")
        {
            switch (rnd.Next(4))
            {
                case 0: subj = "add " + m.Noun + " defaults"; break;
                case 1: subj = "define " + m.Noun + " limits"; break;
                case 2: subj = "introduce " + name + " constant"; break;
                default: subj = "add default limits for " + m.Noun; break;
            }
        }
        else if (m.Kind == "enum")
        {
            switch (rnd.Next(3))
            {
                case 0: subj = "add " + name + " enum"; break;
                case 1: subj = "introduce " + name + " values"; break;
                default: subj = "model " + m.Noun + " states with " + name; break;
            }
        }
        else
        {
            switch (rnd.Next(3))
            {
                case 0: subj = "add " + name + " type"; break;
                case 1: subj = "define " + name + " shape"; break;
                default: subj = "introduce " + name; break;
            }
        }
        string extra = (rnd.Next(4) == 0 && subj.IndexOf(scope) < 0) ? " in " + scope : "";
        return Compose(type, scope, subj, extra);
    }

    string SwapMessage(GenFile g, Chunk old, Chunk m)
    {
        string scope = g.Slug, subj;
        switch (rnd.Next(3))
        {
            case 0: subj = "replace " + old.Main + " with " + m.Main; break;
            case 1: subj = "swap " + old.Main + " for " + m.Main; break;
            default: subj = "rework " + scope + " helpers around " + m.Main; break;
        }
        return Compose("refactor", scope, subj, "");
    }

    string ModuleMessage(GenFile g, Chunk m)
    {
        string scope = g.Slug, subj;
        switch (rnd.Next(4))
        {
            case 0: subj = "add " + scope + " module"; break;
            case 1: subj = "scaffold " + scope + " module with " + m.Main; break;
            case 2: subj = "introduce " + scope + " helpers"; break;
            default: subj = "create " + scope + " module"; break;
        }
        return Compose(rnd.Next(10) == 0 ? "chore" : "feat", scope, subj, "");
    }

    string TextNewMessage(TextFile tf)
    {
        switch (tf.Kind)
        {
            case "json": case "yaml":
                return Compose("chore", "config", rnd.Next(2) == 0 ? "add " + tf.Noun + " settings" : "add " + tf.Noun + " config defaults", "");
            case "env": return Compose("chore", "config", "add " + tf.Noun + " environment defaults", "");
            case "sql": return Compose("feat", "db", rnd.Next(2) == 0 ? "add " + tf.Table + " table" : "create " + tf.Table + " migration", "");
            case "csv": return Compose("test", "data", "add " + tf.Noun + " sample data", "");
            case "sh": return Compose("chore", "scripts", "add " + tf.Table + " script for " + tf.Noun + " data", "");
            default: return Compose("docs", tf.Noun, rnd.Next(2) == 0 ? "add " + tf.Noun + " notes" : "write up " + tf.Noun + " guidelines", "");
        }
    }

    string TextEditMessage(TextFile tf)
    {
        switch (tf.Kind)
        {
            case "json": case "yaml":
                return Compose("chore", "config", rnd.Next(2) == 0 ? "tune " + tf.Noun + " settings" : "update " + tf.Noun + " defaults", "");
            case "env": return Compose("chore", "config", "update " + tf.Noun + " environment defaults", "");
            case "sql": return Compose("fix", "db", rnd.Next(2) == 0 ? "adjust " + tf.Table + " columns" : "update " + tf.Table + " migration", "");
            case "csv": return Compose("test", "data", "refresh " + tf.Noun + " sample data", "");
            case "sh": return Compose("chore", "scripts", "update " + tf.Table + " script", "");
            default: return Compose("docs", tf.Noun, rnd.Next(2) == 0 ? "expand " + tf.Noun + " notes" : "update " + tf.Noun + " notes", "");
        }
    }

    static readonly string[] ChoreConv =
    {
        "chore: tidy up project files", "chore: update gitignore", "chore: clean up", "docs: fix typos in README", "docs: update readme",
        "style: format code", "refactor: simplify helpers", "test: add more cases", "fix: handle edge cases", "perf: reduce allocations"
    };
    static readonly string[] ChoreScoped =
    {
        "style({0}): format module", "refactor({0}): simplify naming", "fix({0}): handle edge case", "test({0}): add more cases",
        "docs({0}): fix typos", "chore({0}): tidy up"
    };
    static readonly string[] ChorePlain =
    {
        "Fix typo", "Minor cleanup", "Update docs", "Tidy up", "Format code", "Small refactor", "Address review comments",
        "Update readme", "Fix edge case", "Cleanup"
    };

    // A commit that changes no file; used for the share of commits that does not touch a file.
    void Chore(CommitPlan plan)
    {
        double r = rnd.NextDouble();
        if (live.Count > 0 && r < 0.40)
            plan.Message = ChoreScoped[rnd.Next(ChoreScoped.Length)].Replace("{0}", live[rnd.Next(live.Count)].Slug);
        else if (r < 0.70)
            plan.Message = ChoreConv[rnd.Next(ChoreConv.Length)];
        else
            plan.Message = ChorePlain[rnd.Next(ChorePlain.Length)];
    }
}
