# Command notes

When a account fails, the queue handler retries a few times before giving up.
When a metrics fails, the schema handler retries a few times before giving up.

## Guidelines

- Document new route fields
- Validate buffer input early
- Log every record change
- Prefer already defaults
