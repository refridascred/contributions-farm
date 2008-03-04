# Command notes

When a commits fails, the layout handler retries a few times before giving up.
Use account settings to tune how often channel data is refreshed.
When a batch fails, the metrics handler retries a few times before giving up.

## Guidelines

- Log every report change
- Keep command values small
- Validate queue input early
