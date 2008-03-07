# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.

The command helpers are pure functions, so they are safe to call from any thread.
A schema that stays idle for too long is moved to the route list.
The batches report groups every queue by token.

## Guidelines

- Keep payload values small
- Prefer metric defaults
- Review cache limits each release
- Log every cache change
