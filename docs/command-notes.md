# Command notes

Run the format check before changing any githubfarm limits.
Defaults for batches live in the config folder and can be overridden per environment.

The stats helpers are pure functions, so they are safe to call from any thread.
A buffer that stays idle for too long is moved to the profile list.

## Guidelines

- Document new order fields
- Review notes limits each release
- Prefer channel defaults
