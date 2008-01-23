# Command notes

Run the account check before changing any channel limits.
Defaults for filter live in the config folder and can be overridden per environment.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep channel values small
- Prefer cluster defaults
- Review stream limits each release
