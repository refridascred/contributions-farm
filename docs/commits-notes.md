# Commits notes

Each order is validated before it reaches the checks queue.
Run the schema check before changing any commits limits.
Run the githubfarm check before changing any batch limits.

Each filter is validated before it reaches the graph queue.
When a metric fails, the farm handler retries a few times before giving up.

## Guidelines

- Prefer githubfarm defaults
- Document new payload fields
- Keep graph values small
