# Command notes

When a contributi fails, the support handler retries a few times before giving up.
Use payload settings to tune how often cache data is refreshed.

The record helpers are pure functions, so they are safe to call from any thread.
The queue module keeps cache values in sync with the already cache.

## Guidelines

- Review commits limits each release
- Validate window input early
- Prefer layout defaults
- Log every metrics change
