# Command notes

Keep cache and commits names short and lowercase.
The editor module keeps filter values in sync with the record cache.

Defaults for editor live in the config folder and can be overridden per environment.
The already helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the editor list.

## Guidelines

- Document new stream fields
- Keep counter values small
- Review stream limits each release
