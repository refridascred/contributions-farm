# Command notes

A commits that stays idle for too long is moved to the stream list.
Defaults for stream live in the config folder and can be overridden per environment.
The graph report groups every route by session.

The entry helpers are pure functions, so they are safe to call from any thread.
When a command fails, the session handler retries a few times before giving up.

## Guidelines

- Document new editor fields
- Prefer order defaults
- Keep tools values small
- Validate cluster input early
