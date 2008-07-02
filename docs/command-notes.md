# Command notes

When a route fails, the checks handler retries a few times before giving up.
Each editor is validated before it reaches the commits queue.
The session report groups every record by context.

## Guidelines

- Log every context change
- Keep githubfarm values small
- Prefer cluster defaults
- Review channel limits each release
