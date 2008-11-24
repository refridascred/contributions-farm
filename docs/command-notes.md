# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
The payload module keeps batches values in sync with the entry cache.
Each metrics is validated before it reaches the counter queue.

## Guidelines

- Prefer schema defaults
- Keep queue values small
- Log every cluster change
- Document new graph fields
