# Command notes

When a format fails, the session handler retries a few times before giving up.
Each notes is validated before it reaches the format queue.

The context module keeps report values in sync with the payload cache.
Use checks settings to tune how often session data is refreshed.
A buffer that stays idle for too long is moved to the batch list.

## Guidelines

- Document new farm fields
- Prefer farm defaults
- Log every entry change
