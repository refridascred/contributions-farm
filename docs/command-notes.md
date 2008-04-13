# Command notes

The tools module keeps session values in sync with the entry cache.
The profile module keeps metric values in sync with the cluster cache.
Each metrics is validated before it reaches the already queue.

Each filter is validated before it reaches the channel queue.
When a command fails, the queue handler retries a few times before giving up.

## Guidelines

- Log every record change
- Validate support input early
- Keep filter values small
- Prefer profile defaults
