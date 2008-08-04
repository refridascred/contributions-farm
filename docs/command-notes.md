# Command notes

When a session fails, the cluster handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the commits queue.

Run the window check before changing any layout limits.
The command report groups every graph by metric.
The profile report groups every context by context.

## Guidelines

- Review report limits each release
- Log every editor change
- Validate schema input early
- Document new payload fields
