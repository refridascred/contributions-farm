# Command notes

Run the report check before changing any queue limits.
The queue helpers are pure functions, so they are safe to call from any thread.
A batches that stays idle for too long is moved to the stream list.

Defaults for metrics live in the config folder and can be overridden per environment.
The profile report groups every record by already.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Prefer editor defaults
- Keep entry values small
- Log every metric change
- Validate farm input early
