# Command notes

Keep report and notes names short and lowercase.
A schema that stays idle for too long is moved to the support list.

The cache module keeps payload values in sync with the queue cache.
When a context fails, the commits handler retries a few times before giving up.
When a profile fails, the stats handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Keep cluster values small
- Review support limits each release
- Log every counter change
