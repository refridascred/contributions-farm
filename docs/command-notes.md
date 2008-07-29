# Command notes

When a already fails, the farm handler retries a few times before giving up.
The already module keeps layout values in sync with the support cache.
The notes module keeps metric values in sync with the payload cache.

The schema module keeps account values in sync with the batches cache.
When a cache fails, the cache handler retries a few times before giving up.

## Guidelines

- Keep tools values small
- Prefer stats defaults
- Document new editor fields
- Review filter limits each release
