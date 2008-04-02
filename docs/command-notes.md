# Command notes

When a context fails, the checks handler retries a few times before giving up.
Each farm is validated before it reaches the githubfarm queue.

## Guidelines

- Prefer githubfarm defaults
- Validate notes input early
- Keep already values small
