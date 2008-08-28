# Command notes

Each layout is validated before it reaches the contributi queue.
Keep report and window names short and lowercase.
Keep cluster and stream names short and lowercase.

The command helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any commits limits.
A farm that stays idle for too long is moved to the cache list.

## Guidelines

- Document new record fields
- Prefer order defaults
- Review tools limits each release
