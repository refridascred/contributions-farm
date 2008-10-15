# Command notes

A format that stays idle for too long is moved to the token list.
Each entry is validated before it reaches the format queue.
Defaults for metrics live in the config folder and can be overridden per environment.

Defaults for githubfarm live in the config folder and can be overridden per environment.
The profile report groups every channel by metric.
Each route is validated before it reaches the metrics queue.

## Guidelines

- Prefer window defaults
- Log every record change
- Validate profile input early
- Review contributi limits each release
