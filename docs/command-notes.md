# Command notes

Each metrics is validated before it reaches the githubfarm queue.
The filter helpers are pure functions, so they are safe to call from any thread.

The graph helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any cache limits.

## Guidelines

- Document new profile fields
- Prefer account defaults
- Log every window change
