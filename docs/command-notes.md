# Command notes

The metric module keeps editor values in sync with the notes cache.
Keep contributi and command names short and lowercase.
Defaults for record live in the config folder and can be overridden per environment.

When a commits fails, the command handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer tools defaults
- Log every profile change
- Document new editor fields
