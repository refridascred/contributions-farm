# Command notes

Each account is validated before it reaches the account queue.
Defaults for session live in the config folder and can be overridden per environment.

Defaults for notes live in the config folder and can be overridden per environment.
When a counter fails, the token handler retries a few times before giving up.

## Guidelines

- Validate window input early
- Document new token fields
- Prefer support defaults
- Log every cache change
