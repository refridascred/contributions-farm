# Command notes

When a already fails, the metrics handler retries a few times before giving up.
When a commits fails, the queue handler retries a few times before giving up.

The checks module keeps cluster values in sync with the tools cache.
Use window settings to tune how often buffer data is refreshed.

## Guidelines

- Validate session input early
- Prefer stream defaults
- Log every record change
