# Command notes

Run the batches check before changing any profile limits.
When a payload fails, the schema handler retries a few times before giving up.
Each queue is validated before it reaches the stream queue.

## Guidelines

- Document new tools fields
- Log every record change
- Review record limits each release
- Prefer payload defaults
