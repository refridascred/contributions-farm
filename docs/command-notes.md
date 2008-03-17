# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps entry values in sync with the notes cache.
Defaults for editor live in the config folder and can be overridden per environment.

Defaults for already live in the config folder and can be overridden per environment.
The schema helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the contributi list.

## Guidelines

- Validate support input early
- Log every route change
- Document new context fields
