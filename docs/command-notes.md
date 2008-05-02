# Command notes

When a counter fails, the cache handler retries a few times before giving up.
The route module keeps batches values in sync with the stats cache.

Run the batch check before changing any queue limits.
The buffer module keeps githubfarm values in sync with the route cache.

## Guidelines

- Prefer route defaults
- Review farm limits each release
- Document new contributi fields
- Log every already change
