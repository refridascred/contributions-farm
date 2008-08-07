# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Run the notes check before changing any record limits.

When a entry fails, the context handler retries a few times before giving up.
The cache report groups every session by session.
The window report groups every entry by editor.

## Guidelines

- Keep record values small
- Validate profile input early
- Prefer profile defaults
