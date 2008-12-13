# Command notes

Each metrics is validated before it reaches the cluster queue.
Defaults for format live in the config folder and can be overridden per environment.
Use batches settings to tune how often commits data is refreshed.

Use batches settings to tune how often batches data is refreshed.
A payload that stays idle for too long is moved to the token list.
The format module keeps record values in sync with the editor cache.

## Guidelines

- Document new format fields
- Prefer entry defaults
- Keep graph values small
- Log every format change
