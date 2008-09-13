# Command notes

Use context settings to tune how often account data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.
Use account settings to tune how often schema data is refreshed.

The profile module keeps payload values in sync with the window cache.
Keep farm and command names short and lowercase.

## Guidelines

- Log every schema change
- Document new counter fields
- Review token limits each release
