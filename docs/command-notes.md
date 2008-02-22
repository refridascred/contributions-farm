# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
Run the profile check before changing any channel limits.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review command limits each release
- Keep batch values small
- Log every stream change
- Validate format input early
