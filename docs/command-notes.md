# Command notes

Keep metric and profile names short and lowercase.
A support that stays idle for too long is moved to the context list.
When a token fails, the route handler retries a few times before giving up.

The farm report groups every batch by metrics.
Each farm is validated before it reaches the entry queue.

## Guidelines

- Keep record values small
- Document new session fields
- Validate counter input early
- Log every metrics change
