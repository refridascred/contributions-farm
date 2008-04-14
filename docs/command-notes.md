# Command notes

Each cluster is validated before it reaches the record queue.
When a format fails, the record handler retries a few times before giving up.

Each format is validated before it reaches the report queue.
Each notes is validated before it reaches the batches queue.

## Guidelines

- Review report limits each release
- Prefer channel defaults
- Keep githubfarm values small
- Validate already input early
