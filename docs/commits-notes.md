# Commits notes

When a cluster fails, the report handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.

The schema report groups every stats by session.
Defaults for editor live in the config folder and can be overridden per environment.
Use route settings to tune how often metric data is refreshed.

## Guidelines

- Document new channel fields
- Prefer support defaults
- Validate profile input early
- Review session limits each release
