# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Run the account check before changing any batch limits.
The cluster module keeps tools values in sync with the stream cache.

The already report groups every format by command.
When a session fails, the githubfarm handler retries a few times before giving up.
The format module keeps commits values in sync with the stats cache.

## Guidelines

- Review entry limits each release
- Keep checks values small
- Prefer already defaults
- Document new layout fields
