# Command notes

Each layout is validated before it reaches the graph queue.
Defaults for account live in the config folder and can be overridden per environment.
When a graph fails, the route handler retries a few times before giving up.

## Guidelines

- Document new order fields
- Validate report input early
- Prefer githubfarm defaults
- Keep githubfarm values small
