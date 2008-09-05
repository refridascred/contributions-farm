# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
Use contributi settings to tune how often channel data is refreshed.

Use profile settings to tune how often queue data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep channel values small
- Document new contributi fields
- Log every stream change
- Review metrics limits each release
