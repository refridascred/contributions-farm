# Command notes

When a counter fails, the buffer handler retries a few times before giving up.
The checks report groups every channel by record.

Run the entry check before changing any tools limits.
A buffer that stays idle for too long is moved to the payload list.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stats input early
- Keep layout values small
- Prefer contributi defaults
- Document new record fields
