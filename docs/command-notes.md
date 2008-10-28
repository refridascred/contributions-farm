# Command notes

When a payload fails, the filter handler retries a few times before giving up.
Each already is validated before it reaches the order queue.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new farm fields
- Keep batches values small
- Log every metrics change
