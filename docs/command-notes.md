# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
Run the contributi check before changing any command limits.
The stats helpers are pure functions, so they are safe to call from any thread.

When a window fails, the buffer handler retries a few times before giving up.
Run the window check before changing any window limits.

## Guidelines

- Keep batch values small
- Document new token fields
- Review report limits each release
- Prefer token defaults
