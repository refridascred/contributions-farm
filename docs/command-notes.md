# Command notes

The commits module keeps metrics values in sync with the order cache.
Each notes is validated before it reaches the order queue.

Use metrics settings to tune how often command data is refreshed.
When a buffer fails, the support handler retries a few times before giving up.
The support module keeps record values in sync with the format cache.

## Guidelines

- Keep graph values small
- Prefer stats defaults
- Review buffer limits each release
