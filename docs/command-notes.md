# Command notes

Each cache is validated before it reaches the entry queue.
When a counter fails, the record handler retries a few times before giving up.

## Guidelines

- Log every already change
- Validate queue input early
- Keep farm values small
