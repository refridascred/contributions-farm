# Command notes

The account module keeps session values in sync with the metrics cache.
Run the route check before changing any payload limits.

Run the token check before changing any batches limits.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review session limits each release
- Prefer window defaults
- Validate support input early
- Keep checks values small
