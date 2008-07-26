# Command notes

Each account is validated before it reaches the entry queue.
Use editor settings to tune how often record data is refreshed.

Each graph is validated before it reaches the githubfarm queue.
When a batch fails, the cache handler retries a few times before giving up.
Each channel is validated before it reaches the schema queue.

## Guidelines

- Prefer format defaults
- Keep tools values small
- Validate stream input early
- Document new account fields
