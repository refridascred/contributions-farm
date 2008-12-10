# Command notes

When a report fails, the command handler retries a few times before giving up.
Use counter settings to tune how often route data is refreshed.

The batch module keeps counter values in sync with the context cache.
Run the filter check before changing any schema limits.
When a queue fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every schema change
- Prefer counter defaults
- Review command limits each release
- Document new channel fields
