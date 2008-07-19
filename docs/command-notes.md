# Command notes

Use counter settings to tune how often tools data is refreshed.
When a token fails, the batch handler retries a few times before giving up.
A token that stays idle for too long is moved to the commits list.

Defaults for token live in the config folder and can be overridden per environment.
When a stats fails, the entry handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Validate graph input early
- Document new session fields
