# Command notes

Each metric is validated before it reaches the report queue.
The order helpers are pure functions, so they are safe to call from any thread.

Use batch settings to tune how often record data is refreshed.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Keep commits values small
- Document new batches fields
- Log every metrics change
- Prefer stream defaults
