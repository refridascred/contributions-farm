# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the graph handler retries a few times before giving up.
Run the tools check before changing any report limits.

The metric module keeps contributi values in sync with the payload cache.
Each report is validated before it reaches the checks queue.

## Guidelines

- Validate report input early
- Document new window fields
- Log every graph change
- Keep contributi values small
