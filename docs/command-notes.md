# Command notes

A account that stays idle for too long is moved to the stats list.
Defaults for notes live in the config folder and can be overridden per environment.

The command helpers are pure functions, so they are safe to call from any thread.
The session report groups every notes by support.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Keep notes values small
- Prefer stream defaults
- Log every token change
- Document new order fields
