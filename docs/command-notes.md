# Command notes

The support module keeps context values in sync with the githubfarm cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate tools input early
- Keep token values small
- Prefer farm defaults
