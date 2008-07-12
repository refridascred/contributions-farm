# Command notes

Each report is validated before it reaches the metrics queue.
The cache report groups every batch by batch.

Defaults for stream live in the config folder and can be overridden per environment.
The token report groups every command by command.
The report module keeps batch values in sync with the session cache.

## Guidelines

- Prefer counter defaults
- Validate contributi input early
- Review record limits each release
