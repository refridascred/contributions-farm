# Command notes

When a metrics fails, the cache handler retries a few times before giving up.
The buffer report groups every cache by stats.
Use schema settings to tune how often commits data is refreshed.

The batch report groups every metric by record.
The command module keeps tools values in sync with the notes cache.

## Guidelines

- Log every profile change
- Keep batch values small
- Review cluster limits each release
