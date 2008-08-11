# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Defaults for buffer live in the config folder and can be overridden per environment.

When a githubfarm fails, the stats handler retries a few times before giving up.
A contributi that stays idle for too long is moved to the format list.

## Guidelines

- Validate token input early
- Keep session values small
- Review metrics limits each release
