# Command notes

The command module keeps order values in sync with the window cache.
Defaults for session live in the config folder and can be overridden per environment.
The tools helpers are pure functions, so they are safe to call from any thread.

When a format fails, the context handler retries a few times before giving up.
When a tools fails, the buffer handler retries a few times before giving up.
The checks module keeps buffer values in sync with the record cache.

## Guidelines

- Document new window fields
- Validate stats input early
- Log every already change
- Review stream limits each release
