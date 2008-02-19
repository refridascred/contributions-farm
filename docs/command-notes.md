# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
A commits that stays idle for too long is moved to the contributi list.
A report that stays idle for too long is moved to the format list.

Each commits is validated before it reaches the buffer queue.
Run the support check before changing any queue limits.

## Guidelines

- Keep cache values small
- Document new batches fields
- Prefer payload defaults
- Review metrics limits each release
