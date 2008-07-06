# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the batches list.

When a record fails, the record handler retries a few times before giving up.
Each format is validated before it reaches the counter queue.
Each cache is validated before it reaches the layout queue.

## Guidelines

- Validate cache input early
- Keep tools values small
- Review profile limits each release
- Prefer batch defaults
