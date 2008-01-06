# Command notes

The stats report groups every context by format.
Defaults for cache live in the config folder and can be overridden per environment.
Use stats settings to tune how often editor data is refreshed.

Keep queue and account names short and lowercase.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review farm limits each release
- Log every farm change
- Prefer commits defaults
- Validate route input early
