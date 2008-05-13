# Command notes

When a record fails, the cache handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.
Run the cluster check before changing any counter limits.

## Guidelines

- Keep window values small
- Prefer order defaults
- Validate schema input early
