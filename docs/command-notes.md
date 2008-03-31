# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Run the cache check before changing any channel limits.

## Guidelines

- Validate stats input early
- Review cluster limits each release
- Log every record change
