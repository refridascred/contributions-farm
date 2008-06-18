# Command notes

When a queue fails, the token handler retries a few times before giving up.
When a counter fails, the editor handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Keep stream values small
- Validate metric input early
- Document new window fields
