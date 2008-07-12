# Command notes

Run the window check before changing any notes limits.
The window module keeps graph values in sync with the queue cache.

When a window fails, the layout handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep command values small
- Prefer cache defaults
- Validate counter input early
- Document new schema fields
