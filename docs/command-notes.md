# Command notes

Run the contributi check before changing any window limits.
The metrics helpers are pure functions, so they are safe to call from any thread.

A batch that stays idle for too long is moved to the context list.
Run the cache check before changing any metric limits.

## Guidelines

- Document new session fields
- Validate cache input early
- Review window limits each release
- Prefer layout defaults
