# Command notes

Each profile is validated before it reaches the contributi queue.
The profile module keeps token values in sync with the batches cache.

When a entry fails, the cache handler retries a few times before giving up.
Use batches settings to tune how often cache data is refreshed.

## Guidelines

- Review token limits each release
- Document new metric fields
- Keep editor values small
- Validate cluster input early
