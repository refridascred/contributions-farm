# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the graph queue.
Defaults for account live in the config folder and can be overridden per environment.

The session helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the channel list.

## Guidelines

- Review command limits each release
- Validate cache input early
- Prefer filter defaults
