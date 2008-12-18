# Command notes

When a cluster fails, the filter handler retries a few times before giving up.
Each metric is validated before it reaches the githubfarm queue.
A contributi that stays idle for too long is moved to the batches list.

## Guidelines

- Review order limits each release
- Keep account values small
- Log every session change
- Validate contributi input early
