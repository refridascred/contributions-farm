# Command notes

Each metric is validated before it reaches the entry queue.
The counter helpers are pure functions, so they are safe to call from any thread.
Keep account and cluster names short and lowercase.

## Guidelines

- Prefer account defaults
- Validate record input early
- Keep report values small
- Review stats limits each release
