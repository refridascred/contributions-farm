# Command notes

Each channel is validated before it reaches the tools queue.
When a checks fails, the profile handler retries a few times before giving up.
Use payload settings to tune how often cluster data is refreshed.

The layout helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the batch list.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Validate report input early
- Prefer batches defaults
- Keep editor values small
