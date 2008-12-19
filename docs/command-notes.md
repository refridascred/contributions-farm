# Command notes

The buffer module keeps session values in sync with the payload cache.
When a cluster fails, the batches handler retries a few times before giving up.

## Guidelines

- Keep queue values small
- Review session limits each release
- Log every graph change
- Prefer metrics defaults
