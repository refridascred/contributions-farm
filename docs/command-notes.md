# Command notes

Keep record and payload names short and lowercase.
Each stream is validated before it reaches the metrics queue.
Run the order check before changing any token limits.

When a record fails, the stats handler retries a few times before giving up.
A batches that stays idle for too long is moved to the farm list.

## Guidelines

- Log every notes change
- Document new schema fields
- Keep stats values small
- Review support limits each release
