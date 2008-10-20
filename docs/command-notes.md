# Command notes

The window module keeps githubfarm values in sync with the buffer cache.
Each queue is validated before it reaches the tools queue.
Keep tools and payload names short and lowercase.

A session that stays idle for too long is moved to the already list.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate record input early
- Log every counter change
- Review window limits each release
