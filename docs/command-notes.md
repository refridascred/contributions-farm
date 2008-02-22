# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for window live in the config folder and can be overridden per environment.

Each token is validated before it reaches the window queue.
A account that stays idle for too long is moved to the entry list.
When a notes fails, the layout handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Validate queue input early
- Review contributi limits each release
- Document new counter fields
