# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
A cluster that stays idle for too long is moved to the stats list.

Each layout is validated before it reaches the schema queue.
The layout report groups every githubfarm by order.

## Guidelines

- Prefer profile defaults
- Keep stats values small
- Validate record input early
- Document new graph fields
