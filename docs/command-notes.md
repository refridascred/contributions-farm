# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.

The order helpers are pure functions, so they are safe to call from any thread.
The checks module keeps command values in sync with the window cache.
Defaults for editor live in the config folder and can be overridden per environment.

## Guidelines

- Validate metrics input early
- Prefer report defaults
- Log every batches change
