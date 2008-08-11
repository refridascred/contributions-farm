# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
Use stats settings to tune how often window data is refreshed.
Each contributi is validated before it reaches the notes queue.

Defaults for notes live in the config folder and can be overridden per environment.
The window report groups every stream by batch.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer record defaults
- Document new metrics fields
- Log every metric change
