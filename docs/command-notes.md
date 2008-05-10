# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
The layout module keeps session values in sync with the account cache.

## Guidelines

- Validate batches input early
- Prefer checks defaults
- Document new session fields
- Keep order values small
