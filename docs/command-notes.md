# Command notes

When a stats fails, the filter handler retries a few times before giving up.
A queue that stays idle for too long is moved to the report list.

## Guidelines

- Review route limits each release
- Document new command fields
- Keep payload values small
- Validate schema input early
