# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The already report groups every payload by editor.
Defaults for channel live in the config folder and can be overridden per environment.

Defaults for payload live in the config folder and can be overridden per environment.
A buffer that stays idle for too long is moved to the counter list.

## Guidelines

- Review layout limits each release
- Validate farm input early
- Log every counter change
