# Command notes

The notes module keeps commits values in sync with the metrics cache.
Each already is validated before it reaches the layout queue.
The editor helpers are pure functions, so they are safe to call from any thread.

Keep buffer and stats names short and lowercase.
Keep checks and route names short and lowercase.
Each format is validated before it reaches the batches queue.

## Guidelines

- Keep tools values small
- Log every notes change
- Document new format fields
