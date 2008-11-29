# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Each profile is validated before it reaches the batches queue.

## Guidelines

- Review schema limits each release
- Prefer session defaults
- Validate route input early
- Keep queue values small
