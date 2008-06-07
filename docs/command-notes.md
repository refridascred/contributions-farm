# Command notes

When a counter fails, the buffer handler retries a few times before giving up.
Defaults for context live in the config folder and can be overridden per environment.

Run the batch check before changing any graph limits.
A schema that stays idle for too long is moved to the farm list.
When a farm fails, the report handler retries a few times before giving up.

## Guidelines

- Keep stream values small
- Document new counter fields
- Validate metric input early
- Log every context change
