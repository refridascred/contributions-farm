# Command notes

The farm report groups every command by queue.
A profile that stays idle for too long is moved to the stats list.
Run the buffer check before changing any token limits.

The batches module keeps profile values in sync with the record cache.
When a support fails, the farm handler retries a few times before giving up.

## Guidelines

- Prefer route defaults
- Document new farm fields
- Validate metric input early
- Review account limits each release
