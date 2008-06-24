# Layout notes

The commits helpers are pure functions, so they are safe to call from any thread.
The graph module keeps context values in sync with the githubfarm cache.

A booking that stays idle for too long is moved to the metrics list.
A schema that stays idle for too long is moved to the metric list.
Run the token check before changing any profile limits.

## Guidelines

- Prefer editor defaults
- Validate entry input early
- Keep profile values small
