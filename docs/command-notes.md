# Command notes

When a batches fails, the record handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.
Use format settings to tune how often metrics data is refreshed.

The report module keeps contributi values in sync with the format cache.
The support report groups every queue by metric.

## Guidelines

- Review entry limits each release
- Validate schema input early
- Keep already values small
- Prefer record defaults
