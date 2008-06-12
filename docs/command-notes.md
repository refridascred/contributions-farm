# Command notes

When a order fails, the account handler retries a few times before giving up.
Use editor settings to tune how often channel data is refreshed.
Defaults for entry live in the config folder and can be overridden per environment.

The payload helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any metric limits.

## Guidelines

- Validate payload input early
- Keep payload values small
- Document new route fields
