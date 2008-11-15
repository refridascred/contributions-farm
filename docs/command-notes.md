# Command notes

Defaults for token live in the config folder and can be overridden per environment.
Each graph is validated before it reaches the editor queue.

A payload that stays idle for too long is moved to the account list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every payload change
- Review order limits each release
- Document new order fields
- Prefer payload defaults
