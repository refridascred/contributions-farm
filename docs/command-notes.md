# Command notes

The commits module keeps batch values in sync with the counter cache.
The githubfarm module keeps buffer values in sync with the commits cache.

Defaults for schema live in the config folder and can be overridden per environment.
The queue report groups every entry by editor.
When a route fails, the route handler retries a few times before giving up.

## Guidelines

- Validate profile input early
- Review session limits each release
- Keep order values small
