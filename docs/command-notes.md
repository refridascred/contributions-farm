# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
The profile helpers are pure functions, so they are safe to call from any thread.

Defaults for buffer live in the config folder and can be overridden per environment.
When a filter fails, the editor handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the stream list.

## Guidelines

- Review entry limits each release
- Log every buffer change
- Validate checks input early
- Prefer payload defaults
