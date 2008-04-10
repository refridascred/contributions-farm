# Command notes

Each account is validated before it reaches the notes queue.
The commits helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the graph queue.

## Guidelines

- Review record limits each release
- Keep format values small
- Prefer channel defaults
- Log every token change
