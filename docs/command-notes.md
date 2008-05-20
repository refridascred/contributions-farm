# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
The support module keeps counter values in sync with the window cache.
A channel that stays idle for too long is moved to the cluster list.

## Guidelines

- Log every session change
- Prefer already defaults
- Review cache limits each release
- Validate tools input early
