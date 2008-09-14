# Command notes

When a checks fails, the entry handler retries a few times before giving up.
When a account fails, the route handler retries a few times before giving up.
Use farm settings to tune how often schema data is refreshed.

## Guidelines

- Keep buffer values small
- Validate graph input early
- Document new queue fields
