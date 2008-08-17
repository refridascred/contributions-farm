# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Use farm settings to tune how often batch data is refreshed.

## Guidelines

- Validate metric input early
- Document new cache fields
- Prefer context defaults
- Keep window values small
