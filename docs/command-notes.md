# Command notes

When a profile fails, the window handler retries a few times before giving up.
A schema that stays idle for too long is moved to the record list.

When a window fails, the cluster handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.
Use cache settings to tune how often format data is refreshed.

## Guidelines

- Prefer buffer defaults
- Log every notes change
- Review token limits each release
