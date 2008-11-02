# Command notes

Use editor settings to tune how often record data is refreshed.
Defaults for queue live in the config folder and can be overridden per environment.
When a route fails, the editor handler retries a few times before giving up.

The route module keeps queue values in sync with the account cache.
Run the graph check before changing any channel limits.

## Guidelines

- Validate payload input early
- Review window limits each release
- Log every command change
- Prefer support defaults
