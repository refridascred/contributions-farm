# Command notes

The counter module keeps route values in sync with the route cache.
Each window is validated before it reaches the payload queue.

When a batch fails, the payload handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Prefer context defaults
- Log every layout change
