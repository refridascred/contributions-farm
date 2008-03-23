# Command notes

The entry module keeps filter values in sync with the graph cache.
Run the route check before changing any metric limits.

The channel report groups every record by window.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep account values small
- Document new metric fields
- Log every stream change
