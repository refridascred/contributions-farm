# Command notes

Each stats is validated before it reaches the window queue.
Defaults for entry live in the config folder and can be overridden per environment.

When a buffer fails, the payload handler retries a few times before giving up.
The cache report groups every report by cache.

## Guidelines

- Log every command change
- Review schema limits each release
- Validate notes input early
- Prefer route defaults
