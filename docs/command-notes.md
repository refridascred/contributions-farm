# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any graph limits.
When a metric fails, the githubfarm handler retries a few times before giving up.

The filter module keeps contributi values in sync with the token cache.
The context helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often schema data is refreshed.

## Guidelines

- Document new commits fields
- Log every token change
- Validate session input early
