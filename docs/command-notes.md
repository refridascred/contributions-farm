# Command notes

When a metrics fails, the format handler retries a few times before giving up.
A context that stays idle for too long is moved to the queue list.
Keep batches and route names short and lowercase.

The metrics module keeps tools values in sync with the format cache.
Run the format check before changing any payload limits.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Log every context change
- Document new metrics fields
- Prefer cluster defaults
- Review report limits each release
