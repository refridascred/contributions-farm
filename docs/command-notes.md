# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Run the layout check before changing any entry limits.

A metric that stays idle for too long is moved to the notes list.
When a counter fails, the contributi handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Keep window values small
- Document new editor fields
