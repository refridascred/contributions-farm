# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Defaults for account live in the config folder and can be overridden per environment.
Each format is validated before it reaches the window queue.

Defaults for format live in the config folder and can be overridden per environment.
When a support fails, the stream handler retries a few times before giving up.

## Guidelines

- Validate farm input early
- Document new channel fields
- Prefer buffer defaults
