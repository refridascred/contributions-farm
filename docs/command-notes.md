# Command notes

Run the command check before changing any cache limits.
The stats module keeps channel values in sync with the notes cache.
The batch report groups every entry by metrics.

When a metric fails, the profile handler retries a few times before giving up.
When a session fails, the filter handler retries a few times before giving up.
Run the batches check before changing any support limits.

## Guidelines

- Validate record input early
- Review support limits each release
- Prefer session defaults
- Keep batch values small
