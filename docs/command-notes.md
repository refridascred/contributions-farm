# Command notes

When a payload fails, the schema handler retries a few times before giving up.
Each filter is validated before it reaches the payload queue.

The profile report groups every layout by order.
The order helpers are pure functions, so they are safe to call from any thread.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep format values small
- Review support limits each release
- Validate record input early
