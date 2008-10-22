# Editor notes

Each context is validated before it reaches the layout queue.
Run the report check before changing any metrics limits.
Defaults for schema live in the config folder and can be overridden per environment.

The metric module keeps context values in sync with the githubfarm cache.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review format limits each release
- Prefer farm defaults
- Validate report input early
