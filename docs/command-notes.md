# Command notes

Defaults for record live in the config folder and can be overridden per environment.
Run the stats check before changing any farm limits.

The metric module keeps filter values in sync with the token cache.
The command helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the token list.

## Guidelines

- Prefer session defaults
- Document new session fields
- Keep session values small
- Log every profile change
