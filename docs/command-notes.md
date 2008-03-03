# Command notes

When a tools fails, the order handler retries a few times before giving up.
Use editor settings to tune how often batch data is refreshed.
When a channel fails, the queue handler retries a few times before giving up.

The stats helpers are pure functions, so they are safe to call from any thread.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Validate graph input early
- Log every profile change
- Document new account fields
