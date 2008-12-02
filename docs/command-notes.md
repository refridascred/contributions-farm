# Command notes

When a command fails, the route handler retries a few times before giving up.
When a already fails, the stream handler retries a few times before giving up.

The channel module keeps already values in sync with the context cache.
Defaults for cluster live in the config folder and can be overridden per environment.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Log every already change
- Document new already fields
- Validate payload input early
- Keep context values small
