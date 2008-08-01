# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
A notes that stays idle for too long is moved to the report list.
A metrics that stays idle for too long is moved to the route list.

Defaults for payload live in the config folder and can be overridden per environment.
A token that stays idle for too long is moved to the metrics list.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Log every stream change
- Prefer token defaults
- Keep format values small
- Review entry limits each release
