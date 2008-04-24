# Command notes

Run the graph check before changing any context limits.
Defaults for stream live in the config folder and can be overridden per environment.
Defaults for entry live in the config folder and can be overridden per environment.

When a window fails, the session handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new token fields
- Prefer session defaults
- Validate tools input early
