# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Defaults for record live in the config folder and can be overridden per environment.
Defaults for editor live in the config folder and can be overridden per environment.

The commits helpers are pure functions, so they are safe to call from any thread.
The entry module keeps entry values in sync with the report cache.
Keep entry and cache names short and lowercase.

## Guidelines

- Document new checks fields
- Prefer token defaults
- Keep format values small
