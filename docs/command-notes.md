# Command notes

A batches that stays idle for too long is moved to the buffer list.
Each session is validated before it reaches the cache queue.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer report defaults
- Validate window input early
- Keep route values small
- Log every payload change
