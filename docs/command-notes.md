# Command notes

Run the queue check before changing any cache limits.
Use queue settings to tune how often stats data is refreshed.
Use account settings to tune how often payload data is refreshed.

A cache that stays idle for too long is moved to the account list.
The checks module keeps counter values in sync with the batch cache.
When a editor fails, the batches handler retries a few times before giving up.

## Guidelines

- Log every profile change
- Keep buffer values small
- Validate command input early
- Document new layout fields
