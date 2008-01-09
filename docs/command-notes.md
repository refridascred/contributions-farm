# Command notes

The metric module keeps graph values in sync with the format cache.
Each command is validated before it reaches the metric queue.

The farm report groups every checks by context.
When a token fails, the command handler retries a few times before giving up.
When a notes fails, the command handler retries a few times before giving up.

## Guidelines

- Prefer contributi defaults
- Document new buffer fields
- Review counter limits each release
- Validate layout input early
