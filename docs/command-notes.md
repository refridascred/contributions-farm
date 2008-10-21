# Command notes

The layout module keeps counter values in sync with the notes cache.
Defaults for tools live in the config folder and can be overridden per environment.

A farm that stays idle for too long is moved to the schema list.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer checks defaults
- Keep profile values small
- Review command limits each release
