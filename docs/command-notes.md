# Command notes

When a batches fails, the window handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.
Keep counter and counter names short and lowercase.

## Guidelines

- Validate payload input early
- Log every counter change
- Prefer farm defaults
