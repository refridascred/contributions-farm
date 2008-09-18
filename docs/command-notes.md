# Command notes

Each batch is validated before it reaches the format queue.
When a order fails, the metrics handler retries a few times before giving up.
Use route settings to tune how often order data is refreshed.

## Guidelines

- Document new channel fields
- Review commits limits each release
- Log every context change
