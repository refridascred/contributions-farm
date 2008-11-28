# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
A filter that stays idle for too long is moved to the context list.

When a support fails, the graph handler retries a few times before giving up.
Each githubfarm is validated before it reaches the route queue.
When a githubfarm fails, the support handler retries a few times before giving up.

## Guidelines

- Log every metrics change
- Prefer profile defaults
- Validate account input early
