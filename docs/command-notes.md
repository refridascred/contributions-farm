# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
Each metric is validated before it reaches the stats queue.
Each commits is validated before it reaches the route queue.

The already module keeps account values in sync with the stream cache.
Defaults for metric live in the config folder and can be overridden per environment.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Prefer context defaults
- Keep record values small
- Review context limits each release
