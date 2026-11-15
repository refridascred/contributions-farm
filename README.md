# GitHub Farm

**Made by Scred**

A small Windows app that adds contributions to your GitHub graph.

## How to use

1. Download `GitHubFarm.exe`. You also need [Git for Windows](https://git-scm.com) installed.
2. Click **Connect GitHub account** and sign in through your browser.
3. Pick a repo from the list, or choose **+ Create new repo...** to make a new private one.
4. Set how many contributions you want and choose the dates: **Spread over the last N days**, **One year only** (every commit gets a date inside that calendar year) or **Spread between two years** (random dates from 1 January of the first year to 31 December of the second, never later than now).
5. Leave **Realistic commits** ticked for normal-looking commits (see below), or untick it for plain `contribution N` commits.
6. Press **START** and wait for **DONE**.

If you use a private repo, turn on **Include private contributions on my profile** in your GitHub profile settings.

## Realistic commits

When **Realistic commits** is on (the default), the app first scans the repo it downloaded: file and folder names, the main language and the README. Then every commit gets a message in a normal style (`feat(billing-utils): add clampInvoice helper`, `chore(config): tune queue settings`, `feat(db): add ledger_records table`), built from words found in the repo, and about 95% of the commits also change a file. The other 5% are message-only commits.

There are no fixed templates. Each piece of code is built from scratch out of random statements (loops, branches, counters, comparisons, arithmetic), so every function looks different, and it is written in the repo's main language (Python, JavaScript, TypeScript, C#, Java, Go, Rust or C/C++; for an empty repo the language is picked from the repo name). Besides functions, the generator writes constants, enums and small record types, and also text files: JSON and YAML settings, `.env.example` files, SQL migrations, CSV sample data, shell scripts and markdown notes.

The generated code is never run by the app and does no file, network or process access. Existing files in the repo are never changed, only new files are added. An empty repo also gets a `README.md` and `.gitignore` in its first commit.

To keep the repo from growing without limit, the app creates up to 64 code files and 24 text files and then keeps editing those (swapping one piece for a new one, or rewriting a text file). Because most commits store a new file version, big runs are slower and make the repo larger than message-only runs.

When it is off, every commit is named `contribution N` and only changes `farm.txt`, as before.

## Notes

- Commits are uploaded in batches of 1,000, because GitHub only counts about 1,000 commits from each upload toward the graph.
- Each run adds to the commits already in the repo.
- The app keeps your sign-in in Git's credential manager and deletes its temporary copy of the repo when it's done.
- To check the app without touching GitHub, run `GitHubFarm.exe --selftest result.txt` and read `result.txt`; it should end with `ALL TESTS PASSED`.

## Build from source

No install needed. Windows already includes the compiler. Just double-click `build.bat`; it builds `GitHubFarm.exe` and can run the offline self-test afterwards. It runs this command:

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /nologo /target:winexe /r:System.Web.Extensions.dll /out:GitHubFarm.exe GitHubFarm.cs
```
