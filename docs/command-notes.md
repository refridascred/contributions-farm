# Command notes

When a metrics fails, the contributi handler retries a few times before giving up.
Run the filter check before changing any graph limits.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Prefer metric defaults
- Review buffer limits each release
- Validate batches input early
- Log every window change
