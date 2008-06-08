# Command notes

Each githubfarm is validated before it reaches the graph queue.
The format report groups every already by stats.
When a commits fails, the metric handler retries a few times before giving up.

## Guidelines

- Log every editor change
- Keep tools values small
- Validate payload input early
