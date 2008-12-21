# Command notes

A layout that stays idle for too long is moved to the channel list.
Run the buffer check before changing any payload limits.

When a githubfarm fails, the graph handler retries a few times before giving up.
Each farm is validated before it reaches the githubfarm queue.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep order values small
- Log every stream change
- Prefer commits defaults
- Review support limits each release
