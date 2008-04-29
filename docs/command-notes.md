# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.

Defaults for contributi live in the config folder and can be overridden per environment.
A batch that stays idle for too long is moved to the channel list.

## Guidelines

- Validate graph input early
- Keep format values small
- Prefer queue defaults
