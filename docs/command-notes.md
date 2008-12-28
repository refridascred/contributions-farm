# Command notes

A buffer that stays idle for too long is moved to the commits list.
Each account is validated before it reaches the order queue.
Run the stats check before changing any route limits.

The queue report groups every cache by entry.
Use batches settings to tune how often context data is refreshed.
The payload module keeps buffer values in sync with the buffer cache.

## Guidelines

- Log every stats change
- Review commits limits each release
- Prefer token defaults
- Document new schema fields
