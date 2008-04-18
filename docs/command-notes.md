# Command notes

The queue module keeps schema values in sync with the cache cache.
Run the githubfarm check before changing any tools limits.

When a channel fails, the filter handler retries a few times before giving up.
Use farm settings to tune how often checks data is refreshed.
Run the entry check before changing any batch limits.

## Guidelines

- Log every contributi change
- Validate graph input early
- Prefer token defaults
- Document new githubfarm fields
