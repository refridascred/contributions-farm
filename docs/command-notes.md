# Command notes

The account module keeps editor values in sync with the queue cache.
Each filter is validated before it reaches the metric queue.

A order that stays idle for too long is moved to the support list.
Each profile is validated before it reaches the editor queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review tools limits each release
- Log every queue change
- Keep batch values small
- Validate buffer input early
