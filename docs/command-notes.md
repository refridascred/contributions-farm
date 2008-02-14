# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
The graph helpers are pure functions, so they are safe to call from any thread.

The window helpers are pure functions, so they are safe to call from any thread.
The metric module keeps batch values in sync with the format cache.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Log every counter change
- Prefer notes defaults
- Review layout limits each release
- Validate buffer input early
