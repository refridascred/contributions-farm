# Command notes

Each context is validated before it reaches the notes queue.
The window report groups every schema by filter.

Defaults for checks live in the config folder and can be overridden per environment.
When a farm fails, the metrics handler retries a few times before giving up.

## Guidelines

- Review filter limits each release
- Keep order values small
- Validate queue input early
- Prefer buffer defaults
