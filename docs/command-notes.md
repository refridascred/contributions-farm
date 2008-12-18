# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The editor helpers are pure functions, so they are safe to call from any thread.

Each context is validated before it reaches the counter queue.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer format defaults
- Log every githubfarm change
- Review batch limits each release
