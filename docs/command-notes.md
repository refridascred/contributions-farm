# Command notes

The support module keeps support values in sync with the route cache.
When a order fails, the farm handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every stats change
- Prefer stats defaults
- Document new layout fields
- Validate schema input early
