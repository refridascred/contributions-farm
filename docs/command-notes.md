# Command notes

The command module keeps editor values in sync with the command cache.
Keep commits and schema names short and lowercase.

The stream module keeps record values in sync with the editor cache.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Log every queue change
- Prefer entry defaults
- Keep already values small
- Validate cluster input early
