# Command notes

Each schema is validated before it reaches the metrics queue.
The commits module keeps session values in sync with the batch cache.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Validate farm input early
- Document new schema fields
- Log every format change
- Prefer notes defaults
