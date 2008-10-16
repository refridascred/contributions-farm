# Command notes

The layout module keeps contributi values in sync with the account cache.
Each tools is validated before it reaches the record queue.
Run the counter check before changing any commits limits.

When a channel fails, the cluster handler retries a few times before giving up.
Use batches settings to tune how often layout data is refreshed.

## Guidelines

- Keep window values small
- Prefer format defaults
- Document new farm fields
