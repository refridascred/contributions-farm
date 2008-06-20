# Command notes

The counter module keeps counter values in sync with the filter cache.
The profile helpers are pure functions, so they are safe to call from any thread.
The report module keeps channel values in sync with the counter cache.

Run the schema check before changing any tools limits.
Each filter is validated before it reaches the commits queue.

## Guidelines

- Review already limits each release
- Keep queue values small
- Validate profile input early
