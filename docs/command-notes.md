# Command notes

Each record is validated before it reaches the format queue.
Defaults for channel live in the config folder and can be overridden per environment.

Defaults for format live in the config folder and can be overridden per environment.
Run the batches check before changing any metrics limits.
Keep buffer and entry names short and lowercase.

## Guidelines

- Review stream limits each release
- Prefer cache defaults
- Validate batch input early
- Log every record change
