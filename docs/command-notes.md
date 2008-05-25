# Command notes

Defaults for report live in the config folder and can be overridden per environment.
A stats that stays idle for too long is moved to the tools list.
The channel report groups every checks by layout.

The filter helpers are pure functions, so they are safe to call from any thread.
The schema module keeps githubfarm values in sync with the filter cache.
Use metrics settings to tune how often githubfarm data is refreshed.

## Guidelines

- Keep context values small
- Prefer filter defaults
- Validate metric input early
