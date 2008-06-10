# Commits notes

When a payload fails, the filter handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the session handler retries a few times before giving up.

A checks that stays idle for too long is moved to the editor list.
The cache report groups every githubfarm by contributi.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Document new record fields
- Log every commits change
- Prefer window defaults
