# Command notes

A already that stays idle for too long is moved to the githubfarm list.
Run the batches check before changing any metrics limits.
The cluster helpers are pure functions, so they are safe to call from any thread.

The context report groups every buffer by session.
Each stats is validated before it reaches the cache queue.

## Guidelines

- Prefer contributi defaults
- Document new session fields
- Validate layout input early
- Keep checks values small
