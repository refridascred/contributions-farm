# Command notes

When a buffer fails, the metrics handler retries a few times before giving up.
A order that stays idle for too long is moved to the support list.
Each stream is validated before it reaches the window queue.

## Guidelines

- Log every cluster change
- Prefer tools defaults
- Validate githubfarm input early
