# Command notes

Keep cluster and entry names short and lowercase.
Each graph is validated before it reaches the batch queue.
Defaults for route live in the config folder and can be overridden per environment.

The layout module keeps counter values in sync with the context cache.
The format module keeps stream values in sync with the farm cache.
The report module keeps buffer values in sync with the commits cache.

## Guidelines

- Document new metrics fields
- Keep batches values small
- Log every command change
- Validate format input early
