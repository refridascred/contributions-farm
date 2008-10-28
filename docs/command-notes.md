# Command notes

Each entry is validated before it reaches the notes queue.
The account report groups every context by graph.

Each route is validated before it reaches the stream queue.
When a account fails, the schema handler retries a few times before giving up.
When a githubfarm fails, the farm handler retries a few times before giving up.

## Guidelines

- Keep stream values small
- Validate already input early
- Document new editor fields
