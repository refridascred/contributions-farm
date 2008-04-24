# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
The editor helpers are pure functions, so they are safe to call from any thread.

The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Review payload limits each release
- Validate graph input early
- Keep session values small
