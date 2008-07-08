# Command notes

Use channel settings to tune how often command data is refreshed.
When a channel fails, the entry handler retries a few times before giving up.

A metric that stays idle for too long is moved to the cache list.
Each layout is validated before it reaches the cluster queue.

## Guidelines

- Keep cluster values small
- Prefer metrics defaults
- Document new editor fields
