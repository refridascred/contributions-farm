# Command notes

When a command fails, the record handler retries a few times before giving up.
Keep editor and format names short and lowercase.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new layout fields
- Log every editor change
- Keep window values small
- Validate session input early
