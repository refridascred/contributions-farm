# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
When a format fails, the schema handler retries a few times before giving up.
Each entry is validated before it reaches the record queue.

## Guidelines

- Log every batches change
- Validate record input early
- Keep session values small
