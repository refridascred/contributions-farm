# Command notes

Run the channel check before changing any token limits.
Each session is validated before it reaches the command queue.
The graph module keeps editor values in sync with the githubfarm cache.

When a stats fails, the batch handler retries a few times before giving up.
Run the graph check before changing any batch limits.

## Guidelines

- Document new format fields
- Log every graph change
- Prefer editor defaults
