# Command notes

The buffer module keeps command values in sync with the profile cache.
Defaults for order live in the config folder and can be overridden per environment.

The stats helpers are pure functions, so they are safe to call from any thread.
Keep route and filter names short and lowercase.
A counter that stays idle for too long is moved to the session list.

## Guidelines

- Keep notes values small
- Validate cluster input early
- Review tools limits each release
- Prefer route defaults
