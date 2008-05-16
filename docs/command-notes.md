# Command notes

When a batches fails, the report handler retries a few times before giving up.
The record report groups every contributi by stats.

The stats report groups every metric by payload.
Each record is validated before it reaches the format queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cache limits each release
- Document new already fields
- Log every payload change
