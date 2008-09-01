# Command notes

When a report fails, the editor handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Log every queue change
- Keep notes values small
