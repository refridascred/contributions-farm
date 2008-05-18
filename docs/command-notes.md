# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep cache values small
- Review checks limits each release
- Log every checks change
