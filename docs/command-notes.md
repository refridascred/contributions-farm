# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
A route that stays idle for too long is moved to the record list.
Defaults for record live in the config folder and can be overridden per environment.

A stats that stays idle for too long is moved to the buffer list.
A account that stays idle for too long is moved to the metric list.

## Guidelines

- Keep checks values small
- Validate schema input early
- Review commits limits each release
