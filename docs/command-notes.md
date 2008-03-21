# Command notes

Each already is validated before it reaches the profile queue.
Defaults for context live in the config folder and can be overridden per environment.
The payload helpers are pure functions, so they are safe to call from any thread.

The checks report groups every buffer by tools.
Use account settings to tune how often account data is refreshed.

## Guidelines

- Keep farm values small
- Validate tools input early
- Review queue limits each release
