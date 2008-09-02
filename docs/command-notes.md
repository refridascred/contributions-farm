# Command notes

When a batches fails, the entry handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.
Run the stats check before changing any batches limits.

## Guidelines

- Prefer context defaults
- Validate support input early
- Document new channel fields
- Log every counter change
