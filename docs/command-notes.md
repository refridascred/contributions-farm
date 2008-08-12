# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Use profile settings to tune how often window data is refreshed.
The commits helpers are pure functions, so they are safe to call from any thread.

Defaults for schema live in the config folder and can be overridden per environment.
The stream module keeps notes values in sync with the graph cache.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every counter change
- Review already limits each release
- Validate graph input early
- Prefer order defaults
