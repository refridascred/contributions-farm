# Command notes

The format module keeps cluster values in sync with the already cache.
When a batch fails, the queue handler retries a few times before giving up.
Use graph settings to tune how often batches data is refreshed.

## Guidelines

- Prefer support defaults
- Log every counter change
- Document new checks fields
- Validate checks input early
