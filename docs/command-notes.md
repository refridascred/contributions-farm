# Command notes

A format that stays idle for too long is moved to the format list.
The route helpers are pure functions, so they are safe to call from any thread.

A channel that stays idle for too long is moved to the payload list.
Keep cluster and editor names short and lowercase.
When a account fails, the editor handler retries a few times before giving up.

## Guidelines

- Validate payload input early
- Keep cluster values small
- Prefer payload defaults
- Document new farm fields
