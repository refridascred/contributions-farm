# Command notes

When a schema fails, the cache handler retries a few times before giving up.
Defaults for payload live in the config folder and can be overridden per environment.

Defaults for profile live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.
The layout report groups every filter by cluster.

## Guidelines

- Prefer already defaults
- Keep metrics values small
- Validate payload input early
- Log every token change
