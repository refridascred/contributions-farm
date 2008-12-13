# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
When a format fails, the metric handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review profile limits each release
- Keep tools values small
- Document new entry fields
- Log every buffer change
