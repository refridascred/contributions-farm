# Command notes

When a route fails, the cluster handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.
Keep cache and stats names short and lowercase.

Defaults for stream live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the notes list.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer farm defaults
- Review graph limits each release
- Log every githubfarm change
