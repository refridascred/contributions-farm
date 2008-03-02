# Command notes

A already that stays idle for too long is moved to the account list.
Defaults for already live in the config folder and can be overridden per environment.
Use profile settings to tune how often schema data is refreshed.

Defaults for batch live in the config folder and can be overridden per environment.
Run the entry check before changing any already limits.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every notes change
- Prefer channel defaults
- Validate support input early
- Review context limits each release
