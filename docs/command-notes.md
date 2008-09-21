# Command notes

The account report groups every metric by support.
Keep entry and githubfarm names short and lowercase.

Each schema is validated before it reaches the layout queue.
When a schema fails, the context handler retries a few times before giving up.

## Guidelines

- Validate buffer input early
- Log every batch change
- Keep queue values small
