# Command notes

Defaults for account live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.

When a report fails, the token handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the context handler retries a few times before giving up.

## Guidelines

- Validate checks input early
- Log every profile change
- Document new window fields
