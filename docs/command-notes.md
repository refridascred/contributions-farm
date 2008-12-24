# Command notes

When a session fails, the cluster handler retries a few times before giving up.
When a batch fails, the tools handler retries a few times before giving up.
Use metric settings to tune how often channel data is refreshed.

## Guidelines

- Validate metric input early
- Prefer checks defaults
- Log every context change
- Review context limits each release
