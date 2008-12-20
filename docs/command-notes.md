# Command notes

Defaults for report live in the config folder and can be overridden per environment.
When a profile fails, the metric handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate report input early
- Document new githubfarm fields
- Prefer order defaults
- Log every batch change
