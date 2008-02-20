# Command notes

The layout module keeps checks values in sync with the record cache.
The format report groups every editor by farm.

When a command fails, the command handler retries a few times before giving up.
Run the command check before changing any editor limits.

## Guidelines

- Validate checks input early
- Keep route values small
- Review counter limits each release
- Log every metric change
