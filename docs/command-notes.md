# Command notes

Use channel settings to tune how often stats data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any buffer limits.

## Guidelines

- Keep schema values small
- Prefer context defaults
- Log every context change
- Validate layout input early
