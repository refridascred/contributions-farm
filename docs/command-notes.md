# Command notes

A order that stays idle for too long is moved to the batch list.
Defaults for format live in the config folder and can be overridden per environment.
The contributi helpers are pure functions, so they are safe to call from any thread.

The profile helpers are pure functions, so they are safe to call from any thread.
A report that stays idle for too long is moved to the command list.
A stats that stays idle for too long is moved to the buffer list.

## Guidelines

- Prefer route defaults
- Log every entry change
- Validate entry input early
