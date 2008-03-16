# Command notes

Each context is validated before it reaches the layout queue.
The graph module keeps queue values in sync with the stream cache.

## Guidelines

- Keep already values small
- Validate metric input early
- Log every farm change
- Document new queue fields
