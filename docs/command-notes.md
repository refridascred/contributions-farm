# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the layout queue.

A commits that stays idle for too long is moved to the format list.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Keep queue values small
- Log every cache change
- Validate graph input early
- Document new session fields
