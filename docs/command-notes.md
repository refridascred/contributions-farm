# Command notes

Run the order check before changing any payload limits.
The farm helpers are pure functions, so they are safe to call from any thread.
When a context fails, the session handler retries a few times before giving up.

When a route fails, the checks handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.
The graph module keeps layout values in sync with the session cache.

## Guidelines

- Validate checks input early
- Review report limits each release
- Keep report values small
