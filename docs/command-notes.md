# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
Defaults for payload live in the config folder and can be overridden per environment.
Each counter is validated before it reaches the report queue.

Keep route and batch names short and lowercase.
Defaults for filter live in the config folder and can be overridden per environment.
When a editor fails, the command handler retries a few times before giving up.

## Guidelines

- Document new record fields
- Review entry limits each release
- Log every metrics change
- Prefer record defaults
