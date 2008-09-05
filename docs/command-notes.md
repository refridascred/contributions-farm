# Command notes

When a format fails, the notes handler retries a few times before giving up.
Each editor is validated before it reaches the commits queue.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer schema defaults
- Keep queue values small
- Document new stats fields
- Review metrics limits each release
