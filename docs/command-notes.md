# Command notes

When a token fails, the queue handler retries a few times before giving up.
The notes module keeps account values in sync with the buffer cache.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep layout values small
- Prefer graph defaults
- Review queue limits each release
