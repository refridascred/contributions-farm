# Command notes

Each format is validated before it reaches the channel queue.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stats values small
- Prefer window defaults
- Validate cache input early
- Log every commits change
