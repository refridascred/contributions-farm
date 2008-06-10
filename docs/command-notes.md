# Command notes

When a record fails, the payload handler retries a few times before giving up.
When a session fails, the layout handler retries a few times before giving up.

## Guidelines

- Validate session input early
- Review stats limits each release
- Log every session change
- Keep token values small
