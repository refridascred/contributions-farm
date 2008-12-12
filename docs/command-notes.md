# Command notes

Use order settings to tune how often context data is refreshed.
The batches helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the commits handler retries a few times before giving up.

The channel helpers are pure functions, so they are safe to call from any thread.
Use stats settings to tune how often cluster data is refreshed.

## Guidelines

- Review batch limits each release
- Log every metric change
- Prefer filter defaults
- Validate editor input early
