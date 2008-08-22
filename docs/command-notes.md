# Command notes

Each metrics is validated before it reaches the format queue.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any notes limits.

When a metrics fails, the editor handler retries a few times before giving up.
Run the notes check before changing any notes limits.
Keep cache and filter names short and lowercase.

## Guidelines

- Document new metrics fields
- Review metrics limits each release
- Keep counter values small
