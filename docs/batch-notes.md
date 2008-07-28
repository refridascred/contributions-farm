# Batch notes

Use batch settings to tune how often githubfarm data is refreshed.
Each profile is validated before it reaches the buffer queue.

The booking report groups every window by token.
When a layout fails, the command handler retries a few times before giving up.

## Guidelines

- Validate batches input early
- Log every booking change
- Prefer entry defaults
