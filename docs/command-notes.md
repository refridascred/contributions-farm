# Command notes

The batches report groups every batch by channel.
Each githubfarm is validated before it reaches the entry queue.
When a githubfarm fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Prefer farm defaults
- Validate session input early
