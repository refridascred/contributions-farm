# Command notes

The session module keeps graph values in sync with the buffer cache.
Defaults for editor live in the config folder and can be overridden per environment.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Prefer metrics defaults
- Validate context input early
