# Command notes

Each commits is validated before it reaches the payload queue.
When a session fails, the profile handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Validate batch input early
- Log every metrics change
- Document new farm fields
