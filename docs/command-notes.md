# Command notes

The schema module keeps session values in sync with the report cache.
When a stats fails, the stats handler retries a few times before giving up.

When a filter fails, the checks handler retries a few times before giving up.
Run the commits check before changing any context limits.

## Guidelines

- Review entry limits each release
- Document new farm fields
- Keep buffer values small
- Log every filter change
