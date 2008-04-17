# Command notes

Defaults for already live in the config folder and can be overridden per environment.
Keep route and metric names short and lowercase.

A metric that stays idle for too long is moved to the batch list.
A editor that stays idle for too long is moved to the entry list.

## Guidelines

- Review counter limits each release
- Prefer context defaults
- Validate batches input early
- Keep window values small
