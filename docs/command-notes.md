# Command notes

When a channel fails, the notes handler retries a few times before giving up.
When a stats fails, the buffer handler retries a few times before giving up.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new channel fields
- Prefer graph defaults
- Review order limits each release
