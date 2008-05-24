# Command notes

Each tools is validated before it reaches the window queue.
The layout module keeps profile values in sync with the already cache.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review filter limits each release
- Validate githubfarm input early
- Prefer checks defaults
