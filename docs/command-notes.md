# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any report limits.

Each format is validated before it reaches the batch queue.
A metrics that stays idle for too long is moved to the support list.

## Guidelines

- Keep filter values small
- Validate order input early
- Prefer graph defaults
- Review editor limits each release
