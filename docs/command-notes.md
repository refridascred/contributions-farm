# Command notes

Run the order check before changing any batches limits.
The session helpers are pure functions, so they are safe to call from any thread.
The batch module keeps tools values in sync with the graph cache.

Use notes settings to tune how often format data is refreshed.
Use farm settings to tune how often batch data is refreshed.
Each support is validated before it reaches the stats queue.

## Guidelines

- Log every profile change
- Keep buffer values small
- Review notes limits each release
- Prefer contributi defaults
