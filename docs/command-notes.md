# Command notes

A format that stays idle for too long is moved to the queue list.
Keep metrics and githubfarm names short and lowercase.

When a graph fails, the contributi handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the record queue.

## Guidelines

- Prefer session defaults
- Keep githubfarm values small
- Document new payload fields
- Validate graph input early
