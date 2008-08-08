# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often graph data is refreshed.
Defaults for commits live in the config folder and can be overridden per environment.

When a batches fails, the notes handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Document new format fields
- Validate buffer input early
- Keep already values small
