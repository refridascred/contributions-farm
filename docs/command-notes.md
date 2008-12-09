# Command notes

Use window settings to tune how often channel data is refreshed.
When a cache fails, the stream handler retries a few times before giving up.

The record report groups every checks by metric.
The checks report groups every stream by cache.
Defaults for graph live in the config folder and can be overridden per environment.

## Guidelines

- Log every format change
- Keep payload values small
- Review metric limits each release
