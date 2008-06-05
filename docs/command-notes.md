# Command notes

When a profile fails, the channel handler retries a few times before giving up.
Each report is validated before it reaches the contributi queue.
The record module keeps cache values in sync with the layout cache.

Each buffer is validated before it reaches the schema queue.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new batches fields
- Validate counter input early
- Prefer window defaults
- Log every stats change
