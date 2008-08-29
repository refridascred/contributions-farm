# Command notes

Each metrics is validated before it reaches the schema queue.
The commits helpers are pure functions, so they are safe to call from any thread.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Document new buffer fields
- Validate queue input early
- Keep stats values small
