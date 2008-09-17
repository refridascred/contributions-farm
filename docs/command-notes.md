# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.

When a command fails, the buffer handler retries a few times before giving up.
Keep session and queue names short and lowercase.

## Guidelines

- Log every notes change
- Keep stats values small
- Review token limits each release
- Document new layout fields
