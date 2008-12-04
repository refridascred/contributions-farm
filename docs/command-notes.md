# Command notes

The token module keeps counter values in sync with the session cache.
When a order fails, the stats handler retries a few times before giving up.

Use queue settings to tune how often order data is refreshed.
Each window is validated before it reaches the support queue.

## Guidelines

- Log every cache change
- Document new schema fields
- Prefer buffer defaults
