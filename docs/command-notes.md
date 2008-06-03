# Command notes

Each tools is validated before it reaches the already queue.
Run the cluster check before changing any profile limits.
Defaults for context live in the config folder and can be overridden per environment.

Use cluster settings to tune how often commits data is refreshed.
The support module keeps support values in sync with the editor cache.
The batch module keeps batches values in sync with the batch cache.

## Guidelines

- Document new command fields
- Validate farm input early
- Keep tools values small
- Prefer batches defaults
