# Command notes

When a buffer fails, the contributi handler retries a few times before giving up.
Keep buffer and record names short and lowercase.
Each counter is validated before it reaches the record queue.

The route module keeps cache values in sync with the batches cache.
The filter report groups every metric by window.

## Guidelines

- Document new counter fields
- Log every cache change
- Validate payload input early
- Prefer stats defaults
