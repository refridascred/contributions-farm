# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Keep session and githubfarm names short and lowercase.
A buffer that stays idle for too long is moved to the counter list.

## Guidelines

- Prefer contributi defaults
- Keep commits values small
- Validate counter input early
