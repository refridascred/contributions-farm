# Command notes

The cache module keeps report values in sync with the batches cache.
Run the payload check before changing any checks limits.
Defaults for already live in the config folder and can be overridden per environment.

Keep payload and schema names short and lowercase.
Use filter settings to tune how often context data is refreshed.
A farm that stays idle for too long is moved to the command list.

## Guidelines

- Prefer metrics defaults
- Review metric limits each release
- Validate checks input early
