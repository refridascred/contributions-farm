# Command notes

The payload report groups every already by route.
A batches that stays idle for too long is moved to the format list.
When a window fails, the already handler retries a few times before giving up.

The farm module keeps payload values in sync with the notes cache.
When a notes fails, the already handler retries a few times before giving up.

## Guidelines

- Validate entry input early
- Keep format values small
- Log every schema change
- Review window limits each release
