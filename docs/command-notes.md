# Command notes

The window module keeps cluster values in sync with the stats cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every context change
- Document new buffer fields
- Prefer tools defaults
