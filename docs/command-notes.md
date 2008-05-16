# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
Use channel settings to tune how often schema data is refreshed.

Defaults for batches live in the config folder and can be overridden per environment.
Each command is validated before it reaches the commits queue.
Run the cluster check before changing any batches limits.

## Guidelines

- Review graph limits each release
- Prefer commits defaults
- Log every report change
