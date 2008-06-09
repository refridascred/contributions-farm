# Command notes

The token module keeps account values in sync with the schema cache.
When a batch fails, the stream handler retries a few times before giving up.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Keep support values small
- Document new contributi fields
- Validate buffer input early
