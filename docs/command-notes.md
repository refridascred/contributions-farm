# Command notes

A context that stays idle for too long is moved to the buffer list.
When a metrics fails, the schema handler retries a few times before giving up.
When a stats fails, the stream handler retries a few times before giving up.

The metric module keeps checks values in sync with the schema cache.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Review layout limits each release
- Prefer metrics defaults
- Keep record values small
