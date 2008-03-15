# Command notes

The checks module keeps buffer values in sync with the payload cache.
The notes module keeps batches values in sync with the batch cache.
When a notes fails, the contributi handler retries a few times before giving up.

## Guidelines

- Keep profile values small
- Log every buffer change
- Validate payload input early
- Prefer profile defaults
