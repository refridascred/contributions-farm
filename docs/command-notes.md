# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the farm queue.

## Guidelines

- Log every queue change
- Keep token values small
- Prefer channel defaults
