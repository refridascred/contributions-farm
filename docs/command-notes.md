# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the route queue.
Each tools is validated before it reaches the batches queue.

Each payload is validated before it reaches the metric queue.
Use support settings to tune how often context data is refreshed.
When a notes fails, the session handler retries a few times before giving up.

## Guidelines

- Validate contributi input early
- Prefer filter defaults
- Document new cluster fields
