# Command notes

When a command fails, the order handler retries a few times before giving up.
The record module keeps cache values in sync with the stream cache.

## Guidelines

- Log every githubfarm change
- Review batches limits each release
- Keep farm values small
- Validate session input early
