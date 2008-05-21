# Command notes

Each command is validated before it reaches the graph queue.
The cache report groups every report by tools.

The session helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the filter queue.
The report module keeps window values in sync with the farm cache.

## Guidelines

- Document new stream fields
- Validate record input early
- Review filter limits each release
