# Command notes

When a commits fails, the context handler retries a few times before giving up.
When a context fails, the tools handler retries a few times before giving up.

## Guidelines

- Validate editor input early
- Log every record change
- Keep farm values small
- Review queue limits each release
