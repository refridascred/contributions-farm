# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the layout handler retries a few times before giving up.
Each graph is validated before it reaches the batches queue.

A already that stays idle for too long is moved to the farm list.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every batch change
- Review payload limits each release
- Validate stream input early
- Keep channel values small
