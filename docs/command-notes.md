# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any editor limits.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Log every filter change
- Review metrics limits each release
- Keep format values small
- Document new schema fields
