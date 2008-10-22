# Command notes

The tools report groups every cache by token.
The farm report groups every window by order.

A queue that stays idle for too long is moved to the report list.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every route change
- Keep contributi values small
- Validate format input early
