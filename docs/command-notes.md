# Command notes

The stream module keeps farm values in sync with the batches cache.
Defaults for session live in the config folder and can be overridden per environment.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep contributi values small
- Validate schema input early
- Log every token change
