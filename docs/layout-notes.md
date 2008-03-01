# Layout notes

Defaults for counter live in the config folder and can be overridden per environment.
Use farm settings to tune how often already data is refreshed.

The contributi helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the graph list.
A batches that stays idle for too long is moved to the metric list.

## Guidelines

- Review schema limits each release
- Keep stream values small
- Document new editor fields
