# Command notes

Run the metrics check before changing any entry limits.
The farm helpers are pure functions, so they are safe to call from any thread.

Defaults for route live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stream limits each release
- Log every profile change
- Prefer metrics defaults
