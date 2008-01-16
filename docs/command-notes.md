# Command notes

Use already settings to tune how often command data is refreshed.
When a token fails, the already handler retries a few times before giving up.
The command module keeps buffer values in sync with the command cache.

Run the format check before changing any metrics limits.
When a batch fails, the farm handler retries a few times before giving up.
Run the format check before changing any payload limits.

## Guidelines

- Keep command values small
- Review entry limits each release
- Validate session input early
