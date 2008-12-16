# Command notes

Use session settings to tune how often already data is refreshed.
The commits module keeps batches values in sync with the commits cache.
When a window fails, the metric handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Prefer githubfarm defaults
- Review window limits each release
- Log every token change
