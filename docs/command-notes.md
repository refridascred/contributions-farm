# Command notes

Run the cache check before changing any payload limits.
The graph helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the layout handler retries a few times before giving up.

## Guidelines

- Prefer channel defaults
- Keep filter values small
- Log every checks change
- Review account limits each release
