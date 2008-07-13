# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Keep commits and command names short and lowercase.

A channel that stays idle for too long is moved to the queue list.
A tools that stays idle for too long is moved to the support list.

## Guidelines

- Prefer order defaults
- Review queue limits each release
- Keep batches values small
- Document new order fields
