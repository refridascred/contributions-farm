# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Keep contributi and layout names short and lowercase.
Keep format and window names short and lowercase.

Each already is validated before it reaches the checks queue.
Defaults for metrics live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the profile list.

## Guidelines

- Keep route values small
- Prefer checks defaults
- Document new window fields
- Review route limits each release
