# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.

Use report settings to tune how often format data is refreshed.
Keep batches and window names short and lowercase.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Keep entry values small
- Document new window fields
- Prefer stream defaults
- Log every checks change
