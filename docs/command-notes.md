# Command notes

Keep editor and stats names short and lowercase.
The schema report groups every schema by account.
Use cluster settings to tune how often checks data is refreshed.

Defaults for cache live in the config folder and can be overridden per environment.
When a metric fails, the payload handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate window input early
- Document new stream fields
- Prefer counter defaults
