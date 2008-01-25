# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the metric queue.

Each notes is validated before it reaches the batch queue.
Use queue settings to tune how often commits data is refreshed.

## Guidelines

- Prefer batch defaults
- Validate support input early
- Keep batch values small
- Log every schema change
