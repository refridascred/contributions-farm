# Command notes

The cluster module keeps command values in sync with the format cache.
A githubfarm that stays idle for too long is moved to the already list.
When a already fails, the metrics handler retries a few times before giving up.

## Guidelines

- Document new buffer fields
- Prefer command defaults
- Validate payload input early
- Log every counter change
