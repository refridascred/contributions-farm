# Command notes

Each support is validated before it reaches the metrics queue.
Use profile settings to tune how often checks data is refreshed.
Each tools is validated before it reaches the route queue.

The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Review graph limits each release
- Keep entry values small
- Document new editor fields
