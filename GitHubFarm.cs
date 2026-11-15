using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

class GitHubFarm : Form
{
    Button btnConnect, btnStart, btnRefresh;
    Label lblAccount;
    ComboBox cmbRepo;
    TextBox txtLog;
    NumericUpDown numCount, numDays;
    ProgressBar bar;

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
        var log = new StringBuilder();
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
            var sw2 = Stopwatch.StartNew(); f.Farm("st_big", "main", 200000, 365, bare);
            log.AppendLine("200000 commits (create + 200 uploads) took " + sw2.Elapsed.TotalSeconds.ToString("0.0") + "s");
            if (Directory.Exists(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GitHubFarm"), "selftest_st_big")))
                throw new Exception("work folder (with token) was not deleted");
            log.AppendLine("PASS work folder deleted after upload");
            f.Farm("st_empty", "main", 10, 30, bare); // run again: must stack
            string c = f.RunProc("git", "rev-list --count main", null, bare, null).Trim();
            if (c != "205010") throw new Exception("expected 205010 commits, got " + c);
            log.AppendLine("PASS runs stack: 205010 commits total");

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
        Width = 560; Height = 520;
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
        Controls.Add(new Label { Text = "Spread over last N days:", Left = 240, Top = 103, Width = 160 });
        numDays = new NumericUpDown { Left = 405, Top = 100, Width = 120, Minimum = 1, Maximum = 3650, Value = 365 };
        Controls.Add(numDays);

        btnStart = new Button { Text = "START", Left = 15, Top = 140, Width = 510, Height = 36, Enabled = false };
        btnStart.Click += delegate { Start(); };
        Controls.Add(btnStart);

        bar = new ProgressBar { Left = 15, Top = 185, Width = 510, Height = 18 };
        Controls.Add(bar);

        txtLog = new TextBox { Left = 15, Top = 212, Width = 510, Height = 255, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };
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
    void SetBusy(bool busy)
    {
        btnConnect.Enabled = !busy;
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

    void Farm(string repo, string branch, int count, int days, string remote)
    {
        string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GitHubFarm");
        string dir = Path.Combine(root, login + "_" + repo);
        if (Directory.Exists(dir)) ForceDelete(dir);
        Directory.CreateDirectory(root);

        Log("Downloading " + repo + "...");
        Git(root, "clone \"" + remote + "\" \"" + dir + "\"", null);
        Git(dir, "config user.name \"" + login + "\"", null);
        Git(dir, "config user.email \"" + email + "\"", null);
        try { Git(dir, "checkout -q " + branch, null); } catch { Git(dir, "checkout -q -B " + branch, null); }

        var rnd = new Random();
        var dates = new List<DateTime>();
        for (int i = 0; i < count; i++) dates.Add(DateTime.Now.AddSeconds(-rnd.NextDouble() * days * 86400.0));
        dates.Sort();

        Log("Creating " + count + " contributions...");
        // Stream all commits straight into git fast-import (no big buffer in memory).
        string parent = null;
        try { parent = RunProc("git", "rev-parse --verify -q HEAD", null, dir, null).Trim(); } catch { }
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
                string msg = "contribution " + (i + 1);
                string content = dates[i].ToString("yyyy-MM-dd HH:mm:ss") + "\n";
                w.Write(head);
                w.Write("author "); w.Write(who);
                w.Write("committer "); w.Write(who);
                w.Write("data " + msg.Length + "\n" + msg + "\n");
                if (i == 0 && !string.IsNullOrEmpty(parent)) w.Write("from " + parent + "\n");
                w.Write("M 100644 inline farm.txt\ndata " + content.Length + "\n" + content + "\n");
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
