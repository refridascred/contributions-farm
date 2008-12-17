# Command notes

Use order settings to tune how often account data is refreshed.
The already helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Document new command fields
- Keep githubfarm values small
- Review batches limits each release
- Validate counter input early
