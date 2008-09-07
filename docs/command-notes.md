# Command notes

Keep stream and metric names short and lowercase.
Use record settings to tune how often cache data is refreshed.

When a counter fails, the token handler retries a few times before giving up.
A batches that stays idle for too long is moved to the route list.
When a support fails, the filter handler retries a few times before giving up.

## Guidelines

- Review route limits each release
- Validate layout input early
- Prefer already defaults
- Document new cache fields
