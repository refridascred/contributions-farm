# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
Use farm settings to tune how often stream data is refreshed.

The profile helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the layout queue.
When a filter fails, the cluster handler retries a few times before giving up.

## Guidelines

- Validate window input early
- Document new farm fields
- Keep record values small
