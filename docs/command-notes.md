# Command notes

When a stats fails, the notes handler retries a few times before giving up.
A farm that stays idle for too long is moved to the batches list.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stats limits each release
- Validate order input early
- Document new cache fields
