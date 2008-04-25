# Command notes

When a stream fails, the filter handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.
Each stats is validated before it reaches the cache queue.

## Guidelines

- Keep filter values small
- Document new notes fields
- Prefer counter defaults
- Validate layout input early
