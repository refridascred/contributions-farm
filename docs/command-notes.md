# Command notes

The checks module keeps already values in sync with the channel cache.
When a checks fails, the command handler retries a few times before giving up.

## Guidelines

- Log every order change
- Validate already input early
- Review support limits each release
