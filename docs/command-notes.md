# Command notes

Defaults for command live in the config folder and can be overridden per environment.
A support that stays idle for too long is moved to the schema list.

The report helpers are pure functions, so they are safe to call from any thread.
Run the token check before changing any layout limits.
The report module keeps session values in sync with the stream cache.

## Guidelines

- Review buffer limits each release
- Prefer account defaults
- Document new graph fields
- Keep profile values small
