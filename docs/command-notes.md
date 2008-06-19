# Command notes

The format module keeps profile values in sync with the batches cache.
Keep metric and counter names short and lowercase.
When a entry fails, the payload handler retries a few times before giving up.

## Guidelines

- Prefer layout defaults
- Log every counter change
- Validate githubfarm input early
