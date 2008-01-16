# Command notes

Defaults for route live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the metrics queue.

Defaults for entry live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the channel list.

## Guidelines

- Prefer editor defaults
- Keep command values small
- Review order limits each release
- Document new filter fields
