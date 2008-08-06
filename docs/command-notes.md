# Command notes

Each metrics is validated before it reaches the stats queue.
A profile that stays idle for too long is moved to the checks list.

A counter that stays idle for too long is moved to the order list.
The session module keeps graph values in sync with the session cache.
A batch that stays idle for too long is moved to the route list.

## Guidelines

- Validate account input early
- Keep support values small
- Log every stream change
