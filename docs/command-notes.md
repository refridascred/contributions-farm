# Command notes

Each stream is validated before it reaches the stream queue.
Each layout is validated before it reaches the channel queue.

Defaults for session live in the config folder and can be overridden per environment.
Each buffer is validated before it reaches the checks queue.

## Guidelines

- Review layout limits each release
- Prefer buffer defaults
- Validate already input early
