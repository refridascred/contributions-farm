# Command notes

Use metrics settings to tune how often report data is refreshed.
The counter module keeps stream values in sync with the batch cache.
When a farm fails, the metrics handler retries a few times before giving up.

Run the filter check before changing any cache limits.
The farm report groups every format by editor.
Run the cache check before changing any cluster limits.

## Guidelines

- Validate schema input early
- Review already limits each release
- Document new account fields
