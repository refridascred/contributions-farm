# Command notes

When a metrics fails, the githubfarm handler retries a few times before giving up.
When a farm fails, the route handler retries a few times before giving up.

The metric module keeps contributi values in sync with the entry cache.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Log every batch change
- Validate account input early
- Document new contributi fields
- Prefer commits defaults
