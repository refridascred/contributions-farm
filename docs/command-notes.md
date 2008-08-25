# Command notes

A layout that stays idle for too long is moved to the record list.
Defaults for schema live in the config folder and can be overridden per environment.
The route module keeps editor values in sync with the command cache.

Each graph is validated before it reaches the cluster queue.
The stream report groups every notes by schema.

## Guidelines

- Validate notes input early
- Keep metric values small
- Log every notes change
- Prefer account defaults
