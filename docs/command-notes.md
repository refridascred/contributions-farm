# Command notes

The metric module keeps farm values in sync with the stats cache.
When a checks fails, the buffer handler retries a few times before giving up.
The farm module keeps token values in sync with the notes cache.

Run the session check before changing any metrics limits.
The githubfarm module keeps schema values in sync with the payload cache.

## Guidelines

- Log every batches change
- Prefer contributi defaults
- Validate tools input early
- Keep farm values small
