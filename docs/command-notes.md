# Command notes

Each record is validated before it reaches the notes queue.
The report helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the counter handler retries a few times before giving up.

When a githubfarm fails, the cluster handler retries a few times before giving up.
Each window is validated before it reaches the cluster queue.

## Guidelines

- Keep commits values small
- Validate farm input early
- Document new token fields
