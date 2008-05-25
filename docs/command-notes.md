# Command notes

When a commits fails, the order handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review entry limits each release
- Keep record values small
- Log every support change
- Prefer order defaults
