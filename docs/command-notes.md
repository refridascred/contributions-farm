# Command notes

Each metric is validated before it reaches the metric queue.
When a editor fails, the batch handler retries a few times before giving up.
Use metric settings to tune how often cluster data is refreshed.

## Guidelines

- Review support limits each release
- Log every stats change
- Prefer commits defaults
