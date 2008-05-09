# Metric notes

The graph helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the counter queue.
Run the layout check before changing any githubfarm limits.

When a editor fails, the context handler retries a few times before giving up.
Each channel is validated before it reaches the stats queue.
Each tools is validated before it reaches the layout queue.

## Guidelines

- Review filter limits each release
- Log every booking change
- Validate cluster input early
