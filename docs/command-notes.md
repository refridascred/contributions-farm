# Command notes

When a tools fails, the metrics handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.

A session that stays idle for too long is moved to the graph list.
A support that stays idle for too long is moved to the buffer list.

## Guidelines

- Document new command fields
- Validate cache input early
- Keep token values small
- Prefer metrics defaults
