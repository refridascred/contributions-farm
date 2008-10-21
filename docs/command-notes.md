# Command notes

Each stream is validated before it reaches the format queue.
Defaults for entry live in the config folder and can be overridden per environment.
When a support fails, the batch handler retries a few times before giving up.

## Guidelines

- Keep token values small
- Prefer command defaults
- Validate support input early
- Log every editor change
