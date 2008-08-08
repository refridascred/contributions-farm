# Command notes

A cache that stays idle for too long is moved to the token list.
Keep account and checks names short and lowercase.
A route that stays idle for too long is moved to the schema list.

Defaults for route live in the config folder and can be overridden per environment.
A metric that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer cluster defaults
- Keep editor values small
- Validate filter input early
- Review support limits each release
