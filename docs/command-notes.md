# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
Run the githubfarm check before changing any batch limits.
A format that stays idle for too long is moved to the report list.

The schema helpers are pure functions, so they are safe to call from any thread.
The stats report groups every payload by buffer.

## Guidelines

- Log every order change
- Review metrics limits each release
- Validate graph input early
