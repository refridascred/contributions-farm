# Command notes

The cache module keeps queue values in sync with the batches cache.
Use report settings to tune how often context data is refreshed.

When a schema fails, the cluster handler retries a few times before giving up.
Run the queue check before changing any session limits.

## Guidelines

- Log every route change
- Prefer batches defaults
- Review stats limits each release
- Keep route values small
