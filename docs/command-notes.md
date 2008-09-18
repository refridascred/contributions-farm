# Command notes

Defaults for session live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.

A checks that stays idle for too long is moved to the record list.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Keep editor values small
- Validate entry input early
- Document new entry fields
