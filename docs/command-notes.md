# Command notes

Each buffer is validated before it reaches the checks queue.
A counter that stays idle for too long is moved to the commits list.

Each context is validated before it reaches the queue queue.
Run the counter check before changing any record limits.
A stats that stays idle for too long is moved to the notes list.

## Guidelines

- Review stream limits each release
- Prefer batches defaults
- Log every cluster change
