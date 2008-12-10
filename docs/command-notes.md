# Command notes

The context module keeps filter values in sync with the counter cache.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep checks values small
- Log every schema change
- Review route limits each release
- Validate schema input early
