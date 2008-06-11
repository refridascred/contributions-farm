# Command notes

Each batches is validated before it reaches the cluster queue.
Run the report check before changing any context limits.

Run the buffer check before changing any batches limits.
When a format fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Log every format change
- Keep account values small
- Prefer stats defaults
