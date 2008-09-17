# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The token module keeps payload values in sync with the checks cache.

## Guidelines

- Keep context values small
- Validate graph input early
- Document new channel fields
