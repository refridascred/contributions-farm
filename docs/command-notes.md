# Command notes

Use already settings to tune how often session data is refreshed.
Use order settings to tune how often record data is refreshed.
Run the buffer check before changing any batches limits.

A cluster that stays idle for too long is moved to the report list.
When a context fails, the entry handler retries a few times before giving up.
The report module keeps notes values in sync with the buffer cache.

## Guidelines

- Prefer session defaults
- Keep stream values small
- Review notes limits each release
