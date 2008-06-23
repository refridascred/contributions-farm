# Command notes

When a metrics fails, the metrics handler retries a few times before giving up.
Use report settings to tune how often record data is refreshed.
The channel module keeps order values in sync with the cluster cache.

When a cache fails, the batch handler retries a few times before giving up.
The stream module keeps checks values in sync with the metric cache.
The stream report groups every metrics by entry.

## Guidelines

- Prefer schema defaults
- Document new cluster fields
- Validate cache input early
