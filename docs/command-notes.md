# Command notes

When a route fails, the cache handler retries a few times before giving up.
A schema that stays idle for too long is moved to the token list.

## Guidelines

- Validate schema input early
- Review tools limits each release
- Document new already fields
- Keep metrics values small
