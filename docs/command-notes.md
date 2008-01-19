# Command notes

The profile module keeps queue values in sync with the filter cache.
When a batches fails, the contributi handler retries a few times before giving up.

When a commits fails, the cache handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Prefer farm defaults
- Validate route input early
- Keep session values small
- Document new metric fields
