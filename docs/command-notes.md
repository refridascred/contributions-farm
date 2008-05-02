# Command notes

Keep session and context names short and lowercase.
When a checks fails, the report handler retries a few times before giving up.

The order module keeps profile values in sync with the batch cache.
A cluster that stays idle for too long is moved to the batches list.

## Guidelines

- Document new account fields
- Review counter limits each release
- Validate stream input early
