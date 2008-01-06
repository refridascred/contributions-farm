# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
The cache module keeps farm values in sync with the layout cache.

Each batch is validated before it reaches the support queue.
Each layout is validated before it reaches the graph queue.

## Guidelines

- Prefer stats defaults
- Document new contributi fields
- Review queue limits each release
- Validate format input early
