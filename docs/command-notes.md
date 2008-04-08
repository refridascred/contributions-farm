# Command notes

When a payload fails, the queue handler retries a few times before giving up.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Log every layout change
- Validate metrics input early
