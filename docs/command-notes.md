# Command notes

The cluster report groups every counter by record.
A report that stays idle for too long is moved to the commits list.

The token report groups every contributi by queue.
Each channel is validated before it reaches the batches queue.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep schema values small
- Document new cache fields
- Prefer graph defaults
