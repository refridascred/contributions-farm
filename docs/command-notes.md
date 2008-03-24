# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
The batch module keeps metrics values in sync with the payload cache.

When a window fails, the cache handler retries a few times before giving up.
Run the githubfarm check before changing any farm limits.

## Guidelines

- Log every route change
- Document new layout fields
- Prefer record defaults
- Validate checks input early
