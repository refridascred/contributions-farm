# Command notes

When a token fails, the farm handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.
Each githubfarm is validated before it reaches the filter queue.

## Guidelines

- Validate metric input early
- Prefer editor defaults
- Keep graph values small
