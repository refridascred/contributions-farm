# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the format list.
A entry that stays idle for too long is moved to the tools list.

## Guidelines

- Review commits limits each release
- Document new entry fields
- Log every already change
