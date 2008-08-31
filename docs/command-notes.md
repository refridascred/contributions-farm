# Command notes

Each metric is validated before it reaches the counter queue.
A buffer that stays idle for too long is moved to the metrics list.
When a profile fails, the record handler retries a few times before giving up.

A token that stays idle for too long is moved to the report list.
A metrics that stays idle for too long is moved to the command list.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep report values small
- Validate farm input early
- Prefer editor defaults
- Document new entry fields
