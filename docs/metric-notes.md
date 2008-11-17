# Metric notes

Use metrics settings to tune how often entry data is refreshed.
Each order is validated before it reaches the metrics queue.
A route that stays idle for too long is moved to the metric list.

Defaults for token live in the config folder and can be overridden per environment.
Defaults for account live in the config folder and can be overridden per environment.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Keep cache values small
- Validate buffer input early
- Log every account change
- Review record limits each release
