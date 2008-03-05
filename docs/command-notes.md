# Command notes

Use window settings to tune how often command data is refreshed.
The route helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the checks handler retries a few times before giving up.

The metrics helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the batch queue.
A checks that stays idle for too long is moved to the support list.

## Guidelines

- Log every profile change
- Keep stats values small
- Review route limits each release
- Document new graph fields
