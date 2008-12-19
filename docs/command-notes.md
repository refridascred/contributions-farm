# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
A buffer that stays idle for too long is moved to the schema list.

Each context is validated before it reaches the metric queue.
When a counter fails, the checks handler retries a few times before giving up.
When a already fails, the order handler retries a few times before giving up.

## Guidelines

- Document new token fields
- Validate payload input early
- Keep metrics values small
