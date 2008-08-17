# Command notes

The metrics module keeps cache values in sync with the batches cache.
A format that stays idle for too long is moved to the metrics list.
Run the order check before changing any editor limits.

Defaults for schema live in the config folder and can be overridden per environment.
Run the buffer check before changing any stream limits.

## Guidelines

- Prefer order defaults
- Log every editor change
- Validate support input early
- Keep editor values small
