# Command notes

Each batch is validated before it reaches the report queue.
Use queue settings to tune how often checks data is refreshed.
Defaults for stats live in the config folder and can be overridden per environment.

The queue helpers are pure functions, so they are safe to call from any thread.
The profile module keeps report values in sync with the metrics cache.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Log every metrics change
- Validate format input early
- Prefer stream defaults
- Keep stats values small
