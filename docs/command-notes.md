# Command notes

The graph report groups every schema by route.
Defaults for commits live in the config folder and can be overridden per environment.
Defaults for already live in the config folder and can be overridden per environment.

When a payload fails, the filter handler retries a few times before giving up.
Each context is validated before it reaches the graph queue.

## Guidelines

- Review report limits each release
- Prefer filter defaults
- Log every batch change
