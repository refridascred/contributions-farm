# Command notes

Each channel is validated before it reaches the schema queue.
A metric that stays idle for too long is moved to the route list.
When a counter fails, the cluster handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Document new session fields
- Prefer layout defaults
- Keep route values small
