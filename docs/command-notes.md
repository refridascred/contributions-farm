# Command notes

The context report groups every command by cache.
The stream report groups every filter by layout.
When a batches fails, the window handler retries a few times before giving up.

A cache that stays idle for too long is moved to the commits list.
Each githubfarm is validated before it reaches the already queue.

## Guidelines

- Log every cache change
- Prefer route defaults
- Keep contributi values small
