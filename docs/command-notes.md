# Command notes

Run the commits check before changing any farm limits.
Keep contributi and entry names short and lowercase.

A stream that stays idle for too long is moved to the checks list.
When a queue fails, the farm handler retries a few times before giving up.
The stream module keeps counter values in sync with the order cache.

## Guidelines

- Keep tools values small
- Validate entry input early
- Document new metric fields
