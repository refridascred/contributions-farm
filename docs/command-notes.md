# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.
A editor that stays idle for too long is moved to the payload list.

## Guidelines

- Keep editor values small
- Document new graph fields
- Validate format input early
- Log every metric change
