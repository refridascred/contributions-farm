# Command notes

A farm that stays idle for too long is moved to the batches list.
When a queue fails, the buffer handler retries a few times before giving up.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer counter defaults
- Keep report values small
- Log every context change
- Validate batches input early
