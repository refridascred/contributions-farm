# Command notes

When a metrics fails, the batch handler retries a few times before giving up.
Use cluster settings to tune how often buffer data is refreshed.
The report module keeps cluster values in sync with the context cache.

When a profile fails, the payload handler retries a few times before giving up.
Run the stream check before changing any tools limits.
The commits module keeps cluster values in sync with the metric cache.

## Guidelines

- Validate buffer input early
- Log every tools change
- Keep context values small
- Review window limits each release
