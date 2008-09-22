# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
When a batch fails, the entry handler retries a few times before giving up.
When a payload fails, the commits handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Prefer command defaults
- Document new batches fields
- Log every counter change
