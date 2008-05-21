# Command notes

Each support is validated before it reaches the filter queue.
Use metric settings to tune how often payload data is refreshed.
A counter that stays idle for too long is moved to the cluster list.

The cluster helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often route data is refreshed.

## Guidelines

- Review order limits each release
- Keep batch values small
- Prefer cache defaults
- Validate account input early
