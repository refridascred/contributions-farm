# Command notes

The route report groups every checks by support.
Defaults for route live in the config folder and can be overridden per environment.
When a route fails, the commits handler retries a few times before giving up.

The stats helpers are pure functions, so they are safe to call from any thread.
Keep cache and stats names short and lowercase.
Run the format check before changing any contributi limits.

## Guidelines

- Keep support values small
- Prefer checks defaults
- Log every format change
- Review tools limits each release
