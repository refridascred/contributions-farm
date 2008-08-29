# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Each githubfarm is validated before it reaches the batches queue.
The record module keeps notes values in sync with the tools cache.

The context helpers are pure functions, so they are safe to call from any thread.
The window module keeps metric values in sync with the queue cache.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer cluster defaults
- Validate session input early
- Review record limits each release
- Document new metric fields
