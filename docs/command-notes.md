# Command notes

Run the already check before changing any graph limits.
Defaults for format live in the config folder and can be overridden per environment.

The account report groups every order by payload.
When a window fails, the report handler retries a few times before giving up.

## Guidelines

- Log every already change
- Document new batches fields
- Validate window input early
- Review report limits each release
