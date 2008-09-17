# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
Each buffer is validated before it reaches the editor queue.
A editor that stays idle for too long is moved to the profile list.

The profile module keeps command values in sync with the report cache.
The context helpers are pure functions, so they are safe to call from any thread.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Document new record fields
- Keep channel values small
- Review cluster limits each release
- Validate batch input early
