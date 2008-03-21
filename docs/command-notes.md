# Command notes

When a stream fails, the route handler retries a few times before giving up.
The report report groups every stats by entry.
Each batch is validated before it reaches the channel queue.

Use window settings to tune how often notes data is refreshed.
The layout module keeps window values in sync with the format cache.

## Guidelines

- Review payload limits each release
- Log every payload change
- Validate checks input early
