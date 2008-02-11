# Command notes

Use cluster settings to tune how often record data is refreshed.
Each support is validated before it reaches the record queue.

Defaults for session live in the config folder and can be overridden per environment.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the layout handler retries a few times before giving up.

## Guidelines

- Log every githubfarm change
- Document new profile fields
- Validate counter input early
- Prefer already defaults
