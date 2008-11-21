# Command notes

Each notes is validated before it reaches the route queue.
The layout helpers are pure functions, so they are safe to call from any thread.

The context module keeps buffer values in sync with the githubfarm cache.
Each format is validated before it reaches the githubfarm queue.

## Guidelines

- Validate checks input early
- Document new commits fields
- Prefer counter defaults
