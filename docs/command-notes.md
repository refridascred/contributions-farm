# Command notes

Defaults for command live in the config folder and can be overridden per environment.
The commits report groups every counter by counter.
A editor that stays idle for too long is moved to the order list.

The order report groups every profile by command.
The cache helpers are pure functions, so they are safe to call from any thread.
The payload report groups every batch by tools.

## Guidelines

- Review command limits each release
- Prefer cache defaults
- Keep cache values small
