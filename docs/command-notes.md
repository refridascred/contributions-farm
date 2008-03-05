# Command notes

When a githubfarm fails, the tools handler retries a few times before giving up.
Run the stream check before changing any buffer limits.

Each graph is validated before it reaches the entry queue.
The route module keeps already values in sync with the metrics cache.
Keep schema and command names short and lowercase.

## Guidelines

- Log every profile change
- Prefer metric defaults
- Document new graph fields
- Keep session values small
