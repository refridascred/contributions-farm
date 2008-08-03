# Command notes

Each batch is validated before it reaches the stats queue.
Keep contributi and farm names short and lowercase.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
A already that stays idle for too long is moved to the filter list.
When a githubfarm fails, the channel handler retries a few times before giving up.

## Guidelines

- Log every record change
- Keep context values small
- Prefer buffer defaults
