# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Use metrics settings to tune how often stream data is refreshed.
Keep checks and schema names short and lowercase.

## Guidelines

- Log every window change
- Keep support values small
- Review route limits each release
- Validate cluster input early
