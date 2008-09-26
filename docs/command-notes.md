# Command notes

When a graph fails, the contributi handler retries a few times before giving up.
Each editor is validated before it reaches the graph queue.

Each payload is validated before it reaches the contributi queue.
When a notes fails, the format handler retries a few times before giving up.

## Guidelines

- Document new filter fields
- Log every notes change
- Review record limits each release
- Validate counter input early
