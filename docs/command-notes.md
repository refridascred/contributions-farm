# Command notes

Each already is validated before it reaches the metrics queue.
The order report groups every payload by queue.

The account helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the farm list.
The stream module keeps batch values in sync with the filter cache.

## Guidelines

- Review channel limits each release
- Log every commits change
- Prefer commits defaults
- Keep command values small
