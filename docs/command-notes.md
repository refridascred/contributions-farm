# Command notes

Each profile is validated before it reaches the notes queue.
A filter that stays idle for too long is moved to the stream list.

The queue report groups every account by metric.
The graph helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the batches queue.

## Guidelines

- Keep githubfarm values small
- Log every route change
- Document new metric fields
