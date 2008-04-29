# Command notes

Each batches is validated before it reaches the session queue.
Run the schema check before changing any cache limits.

Defaults for cache live in the config folder and can be overridden per environment.
When a record fails, the already handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Keep payload values small
- Validate contributi input early
- Review farm limits each release
