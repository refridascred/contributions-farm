# Command notes

The stats module keeps schema values in sync with the route cache.
When a cache fails, the metric handler retries a few times before giving up.
Use tools settings to tune how often token data is refreshed.

## Guidelines

- Document new session fields
- Log every support change
- Prefer schema defaults
- Validate layout input early
