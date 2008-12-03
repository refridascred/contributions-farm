# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The batches report groups every support by cache.
The layout report groups every token by queue.

Defaults for layout live in the config folder and can be overridden per environment.
A buffer that stays idle for too long is moved to the record list.

## Guidelines

- Validate filter input early
- Prefer cluster defaults
- Keep account values small
