# Command notes

A payload that stays idle for too long is moved to the stream list.
Each support is validated before it reaches the metrics queue.
A batches that stays idle for too long is moved to the record list.

Run the token check before changing any entry limits.
Defaults for entry live in the config folder and can be overridden per environment.
The record report groups every graph by record.

## Guidelines

- Document new support fields
- Validate account input early
- Prefer contributi defaults
