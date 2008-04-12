# Command notes

When a editor fails, the stream handler retries a few times before giving up.
Use queue settings to tune how often metric data is refreshed.
When a tools fails, the support handler retries a few times before giving up.

When a entry fails, the order handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.
Use cluster settings to tune how often metrics data is refreshed.

## Guidelines

- Document new account fields
- Log every stream change
- Review already limits each release
- Prefer session defaults
