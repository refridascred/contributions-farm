# Command notes

Keep session and schema names short and lowercase.
The metric module keeps commits values in sync with the route cache.
Keep checks and record names short and lowercase.

A channel that stays idle for too long is moved to the batches list.
When a format fails, the stats handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Keep layout values small
- Validate report input early
- Review contributi limits each release
