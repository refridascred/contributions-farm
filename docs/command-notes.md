# Command notes

The account module keeps window values in sync with the channel cache.
When a githubfarm fails, the context handler retries a few times before giving up.

## Guidelines

- Log every farm change
- Keep record values small
- Document new window fields
- Validate already input early
