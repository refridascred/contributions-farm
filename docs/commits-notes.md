# Commits notes

The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.

Keep counter and githubfarm names short and lowercase.
Each githubfarm is validated before it reaches the token queue.

## Guidelines

- Review stats limits each release
- Keep command values small
- Validate format input early
- Prefer commits defaults
