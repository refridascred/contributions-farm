# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Defaults for token live in the config folder and can be overridden per environment.

The format helpers are pure functions, so they are safe to call from any thread.
A buffer that stays idle for too long is moved to the already list.

## Guidelines

- Validate metrics input early
- Review tools limits each release
- Log every schema change
- Prefer order defaults
