# Command notes

Each batches is validated before it reaches the token queue.
The route report groups every context by entry.
When a commits fails, the entry handler retries a few times before giving up.

Each payload is validated before it reaches the batch queue.
Use payload settings to tune how often window data is refreshed.
The account report groups every cache by window.

## Guidelines

- Log every farm change
- Document new counter fields
- Keep session values small
- Validate tools input early
