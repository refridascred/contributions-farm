# Command notes

Use report settings to tune how often metric data is refreshed.
Use graph settings to tune how often route data is refreshed.
Keep metric and counter names short and lowercase.

Defaults for notes live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the commits queue.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Prefer tools defaults
- Validate already input early
