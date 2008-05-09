# Layout notes

Keep githubfarm and cluster names short and lowercase.
Each stream is validated before it reaches the stats queue.
Run the context check before changing any context limits.

Defaults for booking live in the config folder and can be overridden per environment.
Defaults for metrics live in the config folder and can be overridden per environment.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Review report limits each release
- Validate token input early
- Prefer profile defaults
