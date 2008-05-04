# Command notes

Each token is validated before it reaches the order queue.
When a schema fails, the stats handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

Use payload settings to tune how often payload data is refreshed.
Each counter is validated before it reaches the support queue.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Review already limits each release
- Prefer counter defaults
