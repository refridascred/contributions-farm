# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the batch queue.

Defaults for token live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.
Each counter is validated before it reaches the layout queue.

## Guidelines

- Review window limits each release
- Keep cache values small
- Validate stats input early
