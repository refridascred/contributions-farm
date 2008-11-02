# Command notes

The payload module keeps order values in sync with the farm cache.
Each record is validated before it reaches the support queue.

The counter module keeps stats values in sync with the graph cache.
A channel that stays idle for too long is moved to the report list.
Use format settings to tune how often record data is refreshed.

## Guidelines

- Log every already change
- Keep already values small
- Review already limits each release
- Validate format input early
