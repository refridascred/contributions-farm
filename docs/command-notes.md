# Command notes

When a tools fails, the route handler retries a few times before giving up.
Keep channel and githubfarm names short and lowercase.

Each checks is validated before it reaches the record queue.
The graph report groups every context by payload.

## Guidelines

- Validate support input early
- Prefer stats defaults
- Keep githubfarm values small
