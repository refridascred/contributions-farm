# Command notes

When a order fails, the metrics handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

Each order is validated before it reaches the graph queue.
Run the profile check before changing any channel limits.

## Guidelines

- Log every record change
- Review metric limits each release
- Keep token values small
