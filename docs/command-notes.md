# Command notes

A checks that stays idle for too long is moved to the metrics list.
Keep counter and payload names short and lowercase.
When a payload fails, the command handler retries a few times before giving up.

Each metric is validated before it reaches the command queue.
A cluster that stays idle for too long is moved to the record list.

## Guidelines

- Keep context values small
- Prefer metrics defaults
- Document new githubfarm fields
- Validate account input early
