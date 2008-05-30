# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
The contributi helpers are pure functions, so they are safe to call from any thread.

Keep support and cluster names short and lowercase.
The counter module keeps schema values in sync with the contributi cache.
A batch that stays idle for too long is moved to the farm list.

## Guidelines

- Review counter limits each release
- Keep counter values small
- Prefer filter defaults
