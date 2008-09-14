# Command notes

A entry that stays idle for too long is moved to the checks list.
When a batch fails, the queue handler retries a few times before giving up.

Keep filter and token names short and lowercase.
Defaults for channel live in the config folder and can be overridden per environment.
Run the graph check before changing any command limits.

## Guidelines

- Document new counter fields
- Validate batch input early
- Prefer session defaults
