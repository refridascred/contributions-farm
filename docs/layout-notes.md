# Layout notes

Keep booking and context names short and lowercase.
The token helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the counter queue.

A tools that stays idle for too long is moved to the route list.
Each order is validated before it reaches the githubfarm queue.

## Guidelines

- Keep cache values small
- Validate report input early
- Prefer farm defaults
