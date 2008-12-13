# Command notes

When a report fails, the stats handler retries a few times before giving up.
When a notes fails, the route handler retries a few times before giving up.

## Guidelines

- Keep githubfarm values small
- Prefer payload defaults
- Log every cluster change
