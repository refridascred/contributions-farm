# Command notes

Each format is validated before it reaches the buffer queue.
Each account is validated before it reaches the counter queue.

When a contributi fails, the entry handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the schema list.

## Guidelines

- Document new entry fields
- Validate route input early
- Review graph limits each release
- Log every schema change
