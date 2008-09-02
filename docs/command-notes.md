# Command notes

A metrics that stays idle for too long is moved to the commits list.
Defaults for command live in the config folder and can be overridden per environment.
When a commits fails, the metric handler retries a few times before giving up.

The checks report groups every cache by metric.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Document new checks fields
- Log every queue change
- Validate window input early
- Review layout limits each release
