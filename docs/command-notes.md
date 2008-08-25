# Command notes

The tools report groups every format by order.
Each metrics is validated before it reaches the buffer queue.

Use account settings to tune how often session data is refreshed.
A window that stays idle for too long is moved to the payload list.
A farm that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer cluster defaults
- Validate batch input early
- Log every farm change
