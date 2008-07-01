# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the payload queue.

Run the token check before changing any editor limits.
Each command is validated before it reaches the metrics queue.
When a report fails, the account handler retries a few times before giving up.

## Guidelines

- Prefer window defaults
- Validate layout input early
- Keep metrics values small
- Log every window change
