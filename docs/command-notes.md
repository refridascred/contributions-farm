# Command notes

Use githubfarm settings to tune how often githubfarm data is refreshed.
Run the account check before changing any queue limits.
The cache module keeps schema values in sync with the counter cache.

Defaults for tools live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new schema fields
- Prefer payload defaults
- Log every metrics change
