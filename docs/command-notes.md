# Command notes

A session that stays idle for too long is moved to the session list.
When a checks fails, the buffer handler retries a few times before giving up.
Keep metric and contributi names short and lowercase.

Run the context check before changing any already limits.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stats input early
- Document new format fields
- Prefer command defaults
