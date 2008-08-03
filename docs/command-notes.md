# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
When a entry fails, the notes handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batch defaults
- Log every account change
- Review editor limits each release
- Document new window fields
