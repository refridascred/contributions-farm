# Command notes

When a metrics fails, the channel handler retries a few times before giving up.
Defaults for cache live in the config folder and can be overridden per environment.
The batch module keeps stream values in sync with the command cache.

## Guidelines

- Document new contributi fields
- Validate graph input early
- Keep githubfarm values small
- Log every already change
