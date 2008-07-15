# Command notes

Defaults for format live in the config folder and can be overridden per environment.
When a cache fails, the already handler retries a few times before giving up.

Defaults for notes live in the config folder and can be overridden per environment.
When a route fails, the queue handler retries a few times before giving up.
Use cluster settings to tune how often account data is refreshed.

## Guidelines

- Review commits limits each release
- Validate channel input early
- Prefer window defaults
- Keep entry values small
