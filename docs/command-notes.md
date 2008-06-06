# Command notes

Each counter is validated before it reaches the profile queue.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review queue limits each release
- Validate layout input early
- Log every account change
- Keep editor values small
