# Command notes

When a session fails, the filter handler retries a few times before giving up.
When a graph fails, the schema handler retries a few times before giving up.

The support module keeps route values in sync with the tools cache.
Use payload settings to tune how often token data is refreshed.
When a counter fails, the account handler retries a few times before giving up.

## Guidelines

- Prefer stream defaults
- Keep record values small
- Document new route fields
- Validate githubfarm input early
