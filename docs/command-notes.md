# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.

A command that stays idle for too long is moved to the notes list.
Each schema is validated before it reaches the commits queue.

## Guidelines

- Review schema limits each release
- Document new checks fields
- Log every notes change
- Prefer githubfarm defaults
