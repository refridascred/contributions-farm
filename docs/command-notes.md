# Command notes

The command report groups every batches by record.
Run the tools check before changing any buffer limits.
Run the payload check before changing any entry limits.

Defaults for channel live in the config folder and can be overridden per environment.
When a batch fails, the commits handler retries a few times before giving up.

## Guidelines

- Prefer command defaults
- Validate filter input early
- Document new batch fields
