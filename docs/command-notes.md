# Command notes

Each githubfarm is validated before it reaches the filter queue.
The tools report groups every notes by cluster.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate token input early
- Prefer session defaults
- Review token limits each release
