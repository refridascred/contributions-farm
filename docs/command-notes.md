# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The editor module keeps metrics values in sync with the batches cache.
When a counter fails, the commits handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Validate contributi input early
- Review report limits each release
