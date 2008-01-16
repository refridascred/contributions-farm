# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
The batch module keeps cluster values in sync with the batches cache.

Each batch is validated before it reaches the stream queue.
Use tools settings to tune how often token data is refreshed.
A contributi that stays idle for too long is moved to the metrics list.

## Guidelines

- Log every cache change
- Document new cluster fields
- Prefer schema defaults
- Review queue limits each release
