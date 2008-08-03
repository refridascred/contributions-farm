# Command notes

When a session fails, the session handler retries a few times before giving up.
Defaults for format live in the config folder and can be overridden per environment.
A batches that stays idle for too long is moved to the cache list.

A order that stays idle for too long is moved to the entry list.
Each batches is validated before it reaches the command queue.
Each payload is validated before it reaches the cache queue.

## Guidelines

- Log every checks change
- Prefer counter defaults
- Document new metric fields
