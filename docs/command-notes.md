# Command notes

The cache module keeps graph values in sync with the notes cache.
Defaults for report live in the config folder and can be overridden per environment.

When a counter fails, the metrics handler retries a few times before giving up.
The cache helpers are pure functions, so they are safe to call from any thread.
Use githubfarm settings to tune how often farm data is refreshed.

## Guidelines

- Document new account fields
- Log every metric change
- Validate support input early
- Keep filter values small
