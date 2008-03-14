# Command notes

Keep format and schema names short and lowercase.
Run the payload check before changing any channel limits.
When a batches fails, the commits handler retries a few times before giving up.

Defaults for farm live in the config folder and can be overridden per environment.
The batch report groups every schema by layout.

## Guidelines

- Review session limits each release
- Validate profile input early
- Prefer route defaults
