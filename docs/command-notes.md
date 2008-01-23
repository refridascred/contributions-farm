# Command notes

When a schema fails, the account handler retries a few times before giving up.
The entry module keeps graph values in sync with the schema cache.

## Guidelines

- Validate route input early
- Prefer token defaults
- Keep session values small
