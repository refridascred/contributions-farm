# Command notes

Each githubfarm is validated before it reaches the editor queue.
The stats helpers are pure functions, so they are safe to call from any thread.

A report that stays idle for too long is moved to the cache list.
The stream report groups every layout by cluster.

## Guidelines

- Log every batches change
- Validate filter input early
- Keep command values small
- Prefer queue defaults
