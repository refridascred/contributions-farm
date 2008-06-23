# Command notes

A commits that stays idle for too long is moved to the counter list.
Defaults for metrics live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.

Run the commits check before changing any account limits.
The notes module keeps already values in sync with the farm cache.

## Guidelines

- Review commits limits each release
- Prefer checks defaults
- Keep graph values small
- Document new cache fields
