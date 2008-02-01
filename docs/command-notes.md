# Command notes

A schema that stays idle for too long is moved to the metrics list.
The support module keeps payload values in sync with the record cache.

The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the notes list.

## Guidelines

- Log every queue change
- Document new route fields
- Keep cluster values small
