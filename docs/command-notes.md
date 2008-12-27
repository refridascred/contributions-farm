# Command notes

A stats that stays idle for too long is moved to the editor list.
The notes helpers are pure functions, so they are safe to call from any thread.

Keep metric and route names short and lowercase.
When a batch fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new cache fields
- Keep token values small
- Prefer queue defaults
- Log every format change
