# Command notes

When a context fails, the stream handler retries a few times before giving up.
A checks that stays idle for too long is moved to the commits list.

The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Prefer cache defaults
- Keep stream values small
- Review checks limits each release
- Validate filter input early
