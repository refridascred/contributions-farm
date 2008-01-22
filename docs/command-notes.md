# Command notes

A format that stays idle for too long is moved to the checks list.
Each already is validated before it reaches the format queue.
The buffer module keeps counter values in sync with the notes cache.

When a command fails, the command handler retries a few times before giving up.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Validate route input early
- Log every session change
- Prefer token defaults
- Review payload limits each release
