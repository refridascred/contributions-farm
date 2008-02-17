# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
Each cluster is validated before it reaches the entry queue.

When a cache fails, the commits handler retries a few times before giving up.
When a entry fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Validate layout input early
- Prefer report defaults
- Review schema limits each release
