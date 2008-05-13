# Command notes

The batch module keeps layout values in sync with the notes cache.
Each layout is validated before it reaches the commits queue.

Each support is validated before it reaches the route queue.
The command helpers are pure functions, so they are safe to call from any thread.
Keep stats and counter names short and lowercase.

## Guidelines

- Log every report change
- Validate metric input early
- Review counter limits each release
