# Command notes

The metric report groups every command by stats.
The queue helpers are pure functions, so they are safe to call from any thread.
Run the stream check before changing any metric limits.

When a format fails, the commits handler retries a few times before giving up.
Each counter is validated before it reaches the schema queue.

## Guidelines

- Validate layout input early
- Log every metrics change
- Document new editor fields
