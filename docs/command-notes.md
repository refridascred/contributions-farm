# Command notes

Run the cache check before changing any session limits.
The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Prefer checks defaults
- Document new editor fields
- Log every channel change
- Validate profile input early
