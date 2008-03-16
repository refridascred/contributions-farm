# Payload notes

The channel helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Validate tools input early
- Log every payload change
- Keep checks values small
- Review editor limits each release
