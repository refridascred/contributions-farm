# Command notes

When a support fails, the filter handler retries a few times before giving up.
A report that stays idle for too long is moved to the batches list.

Each profile is validated before it reaches the stats queue.
The stream module keeps session values in sync with the tools cache.

## Guidelines

- Document new already fields
- Prefer layout defaults
- Review stream limits each release
