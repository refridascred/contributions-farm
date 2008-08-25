# Command notes

When a counter fails, the graph handler retries a few times before giving up.
Each metrics is validated before it reaches the entry queue.
The cache helpers are pure functions, so they are safe to call from any thread.

Each counter is validated before it reaches the checks queue.
A metrics that stays idle for too long is moved to the route list.
Use command settings to tune how often graph data is refreshed.

## Guidelines

- Validate graph input early
- Prefer contributi defaults
- Review filter limits each release
