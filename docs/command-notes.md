# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Each stream is validated before it reaches the already queue.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Prefer window defaults
- Log every context change
- Document new command fields
- Review filter limits each release
