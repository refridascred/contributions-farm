# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any entry limits.
Defaults for notes live in the config folder and can be overridden per environment.

A metrics that stays idle for too long is moved to the farm list.
A entry that stays idle for too long is moved to the record list.

## Guidelines

- Log every editor change
- Document new queue fields
- Validate cache input early
- Prefer counter defaults
