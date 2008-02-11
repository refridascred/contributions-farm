# Command notes

Each payload is validated before it reaches the already queue.
Use route settings to tune how often command data is refreshed.
Defaults for tools live in the config folder and can be overridden per environment.

Keep contributi and batches names short and lowercase.
The buffer helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the metric list.

## Guidelines

- Prefer stats defaults
- Log every contributi change
- Document new counter fields
