# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Validate cache input early
- Document new queue fields
- Prefer format defaults
- Review record limits each release
