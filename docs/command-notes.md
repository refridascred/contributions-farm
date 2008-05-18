# Command notes

A batch that stays idle for too long is moved to the graph list.
Each metrics is validated before it reaches the order queue.

When a counter fails, the cache handler retries a few times before giving up.
Run the stream check before changing any githubfarm limits.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep checks values small
- Prefer farm defaults
- Review order limits each release
- Log every payload change
