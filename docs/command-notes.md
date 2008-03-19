# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
Each format is validated before it reaches the record queue.
A commits that stays idle for too long is moved to the metrics list.

Each stream is validated before it reaches the stream queue.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Document new record fields
- Log every stats change
- Validate batches input early
