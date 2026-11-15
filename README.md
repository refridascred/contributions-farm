# GitHub Farm

**Made by Scred**

A small Windows app that adds contributions to your GitHub graph.

## How to use

1. Download `GitHubFarm.exe`. You also need [Git for Windows](https://git-scm.com) installed.
2. Click **Connect GitHub account** and sign in through your browser.
3. Pick a repo from the list, or choose **+ Create new repo...** to make a new private one.
4. Set how many contributions you want and how many past days to spread them over.
5. Press **START** and wait for **DONE**.

If you use a private repo, turn on **Include private contributions on my profile** in your GitHub profile settings.

## Notes

- Commits are uploaded in batches of 1,000, because GitHub only counts about 1,000 commits from each upload toward the graph.
- Each run adds to the commits already in the repo.
- The app keeps your sign-in in Git's credential manager and deletes its temporary copy of the repo when it's done.

## Build from source

No install needed. Windows already includes the compiler:

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /nologo /target:winexe /r:System.Web.Extensions.dll /out:GitHubFarm.exe GitHubFarm.cs
```
