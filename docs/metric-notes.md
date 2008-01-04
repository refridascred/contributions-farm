# Metric notes

The contributi report groups every token by metrics.
Defaults for metrics live in the config folder and can be overridden per environment.

Run the record check before changing any context limits.
Each channel is validated before it reaches the order queue.

## Guidelines

- Prefer format defaults
- Keep counter values small
- Validate farm input early
- Review session limits each release
