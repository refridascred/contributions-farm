# Command notes

When a batches fails, the record handler retries a few times before giving up.
A support that stays idle for too long is moved to the support list.

The token module keeps context values in sync with the batches cache.
Run the session check before changing any editor limits.
Keep queue and schema names short and lowercase.

## Guidelines

- Review schema limits each release
- Document new filter fields
- Log every profile change
