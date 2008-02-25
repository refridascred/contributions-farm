# Command notes

A already that stays idle for too long is moved to the commits list.
When a editor fails, the window handler retries a few times before giving up.
Each payload is validated before it reaches the commits queue.

## Guidelines

- Prefer channel defaults
- Keep batches values small
- Validate already input early
