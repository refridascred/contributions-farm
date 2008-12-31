# Command notes

Use githubfarm settings to tune how often order data is refreshed.
The payload report groups every payload by metrics.
The farm module keeps batches values in sync with the record cache.

Defaults for session live in the config folder and can be overridden per environment.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review window limits each release
- Validate route input early
- Log every metrics change
- Keep layout values small
