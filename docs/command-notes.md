# Command notes

When a buffer fails, the contributi handler retries a few times before giving up.
Each commits is validated before it reaches the commits queue.
The context report groups every profile by buffer.

A batches that stays idle for too long is moved to the graph list.
A format that stays idle for too long is moved to the editor list.
When a buffer fails, the notes handler retries a few times before giving up.

## Guidelines

- Prefer commits defaults
- Review command limits each release
- Log every context change
