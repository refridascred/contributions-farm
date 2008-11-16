# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the buffer list.

## Guidelines

- Validate route input early
- Review commits limits each release
- Keep githubfarm values small
- Prefer counter defaults
