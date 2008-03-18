# Command notes

The metric module keeps session values in sync with the channel cache.
Each queue is validated before it reaches the batches queue.
A contributi that stays idle for too long is moved to the window list.

Each queue is validated before it reaches the order queue.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batch defaults
- Log every context change
- Document new stream fields
- Keep session values small
