# Command notes

The commits module keeps order values in sync with the layout cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the report check before changing any context limits.

## Guidelines

- Validate cache input early
- Document new graph fields
- Prefer cluster defaults
- Keep token values small
