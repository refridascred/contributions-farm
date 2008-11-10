# Command notes

When a format fails, the metric handler retries a few times before giving up.
Run the stream check before changing any context limits.
Use counter settings to tune how often route data is refreshed.

Each filter is validated before it reaches the stream queue.
The token report groups every channel by cache.
Use queue settings to tune how often layout data is refreshed.

## Guidelines

- Review token limits each release
- Prefer metric defaults
- Log every graph change
- Document new batch fields
