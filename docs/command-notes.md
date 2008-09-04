# Command notes

A farm that stays idle for too long is moved to the route list.
Use cache settings to tune how often queue data is refreshed.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep metric values small
- Validate entry input early
- Prefer batches defaults
