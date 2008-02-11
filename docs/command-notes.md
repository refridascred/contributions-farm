# Command notes

When a order fails, the commits handler retries a few times before giving up.
When a metrics fails, the tools handler retries a few times before giving up.
Each filter is validated before it reaches the filter queue.

Each format is validated before it reaches the counter queue.
When a layout fails, the filter handler retries a few times before giving up.

## Guidelines

- Log every contributi change
- Validate window input early
- Keep account values small
- Document new channel fields
