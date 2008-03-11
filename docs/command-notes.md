# Command notes

When a counter fails, the report handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.

Each counter is validated before it reaches the queue queue.
The filter report groups every record by channel.

## Guidelines

- Prefer batches defaults
- Validate counter input early
- Log every profile change
