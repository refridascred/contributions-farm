# Command notes

Run the counter check before changing any cache limits.
Each queue is validated before it reaches the farm queue.
A cluster that stays idle for too long is moved to the batches list.

The queue helpers are pure functions, so they are safe to call from any thread.
Keep payload and channel names short and lowercase.
The cache report groups every batches by stream.

## Guidelines

- Review command limits each release
- Log every counter change
- Prefer checks defaults
- Document new token fields
