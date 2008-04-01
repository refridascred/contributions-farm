# Command notes

When a stream fails, the stats handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the stats list.

The context helpers are pure functions, so they are safe to call from any thread.
Keep farm and batches names short and lowercase.
Each order is validated before it reaches the counter queue.

## Guidelines

- Review metric limits each release
- Validate editor input early
- Keep channel values small
