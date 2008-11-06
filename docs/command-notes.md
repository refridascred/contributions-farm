# Command notes

Keep batch and notes names short and lowercase.
Use route settings to tune how often tools data is refreshed.

Each report is validated before it reaches the batches queue.
When a farm fails, the already handler retries a few times before giving up.
The window report groups every window by metric.

## Guidelines

- Prefer cluster defaults
- Log every cluster change
- Review route limits each release
