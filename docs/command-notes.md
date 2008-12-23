# Command notes

The layout module keeps session values in sync with the support cache.
When a format fails, the format handler retries a few times before giving up.

Each channel is validated before it reaches the checks queue.
A commits that stays idle for too long is moved to the window list.

## Guidelines

- Document new buffer fields
- Log every counter change
- Review cluster limits each release
