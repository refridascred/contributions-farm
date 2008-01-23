# Command notes

A metrics that stays idle for too long is moved to the session list.
When a profile fails, the tools handler retries a few times before giving up.

Each editor is validated before it reaches the editor queue.
Each metrics is validated before it reaches the queue queue.
Keep token and farm names short and lowercase.

## Guidelines

- Validate counter input early
- Prefer session defaults
- Keep queue values small
- Document new schema fields
