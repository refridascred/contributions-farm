# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.

The graph helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the layout queue.
A cache that stays idle for too long is moved to the support list.

## Guidelines

- Document new graph fields
- Log every contributi change
- Review support limits each release
