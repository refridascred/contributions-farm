# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the metric handler retries a few times before giving up.
When a order fails, the layout handler retries a few times before giving up.

## Guidelines

- Document new profile fields
- Log every token change
- Prefer contributi defaults
