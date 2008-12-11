# Command notes

Use cache settings to tune how often support data is refreshed.
The route module keeps graph values in sync with the already cache.
Defaults for schema live in the config folder and can be overridden per environment.

A channel that stays idle for too long is moved to the payload list.
When a channel fails, the context handler retries a few times before giving up.
When a batch fails, the command handler retries a few times before giving up.

## Guidelines

- Document new metrics fields
- Validate filter input early
- Log every metric change
