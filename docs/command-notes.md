# Command notes

The cluster report groups every stream by profile.
The checks module keeps schema values in sync with the report cache.
When a command fails, the format handler retries a few times before giving up.

Keep layout and profile names short and lowercase.
A batches that stays idle for too long is moved to the route list.
Run the metrics check before changing any window limits.

## Guidelines

- Document new window fields
- Validate entry input early
- Review cluster limits each release
- Keep filter values small
