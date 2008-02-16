# Command notes

Run the queue check before changing any route limits.
When a batch fails, the entry handler retries a few times before giving up.
Use metrics settings to tune how often cache data is refreshed.

Keep session and queue names short and lowercase.
The counter module keeps cache values in sync with the cluster cache.
When a checks fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep contributi values small
- Validate report input early
- Prefer queue defaults
- Review already limits each release
