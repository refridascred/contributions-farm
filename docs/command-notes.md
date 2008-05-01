# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
A stream that stays idle for too long is moved to the token list.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Keep command values small
- Review commits limits each release
- Log every channel change
- Validate cache input early
