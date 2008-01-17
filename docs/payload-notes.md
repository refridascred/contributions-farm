# Payload notes

When a booking fails, the stats handler retries a few times before giving up.
Use session settings to tune how often batches data is refreshed.

The layout report groups every command by counter.
A editor that stays idle for too long is moved to the command list.

## Guidelines

- Document new format fields
- Prefer entry defaults
- Review order limits each release
- Validate schema input early
