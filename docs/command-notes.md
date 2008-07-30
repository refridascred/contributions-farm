# Command notes

The counter report groups every metric by entry.
When a buffer fails, the window handler retries a few times before giving up.

Each counter is validated before it reaches the stats queue.
A metrics that stays idle for too long is moved to the batch list.

## Guidelines

- Review notes limits each release
- Document new order fields
- Log every schema change
- Validate stream input early
