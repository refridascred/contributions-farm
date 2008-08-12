# Command notes

A session that stays idle for too long is moved to the editor list.
The cache module keeps cluster values in sync with the queue cache.

Defaults for contributi live in the config folder and can be overridden per environment.
Keep contributi and payload names short and lowercase.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate command input early
- Document new profile fields
- Log every session change
