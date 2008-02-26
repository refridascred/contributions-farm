# Command notes

Use checks settings to tune how often graph data is refreshed.
Each report is validated before it reaches the session queue.

A token that stays idle for too long is moved to the channel list.
When a batch fails, the session handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Keep batch values small
- Validate githubfarm input early
