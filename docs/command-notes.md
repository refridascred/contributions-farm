# Command notes

The metrics module keeps token values in sync with the command cache.
Each filter is validated before it reaches the cluster queue.
The token module keeps token values in sync with the record cache.

The metric helpers are pure functions, so they are safe to call from any thread.
Keep graph and metric names short and lowercase.

## Guidelines

- Review cache limits each release
- Document new route fields
- Log every commits change
- Keep farm values small
