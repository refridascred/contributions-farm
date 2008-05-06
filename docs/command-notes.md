# Command notes

A buffer that stays idle for too long is moved to the schema list.
Each profile is validated before it reaches the route queue.
A order that stays idle for too long is moved to the format list.

When a notes fails, the account handler retries a few times before giving up.
Use layout settings to tune how often cluster data is refreshed.

## Guidelines

- Validate window input early
- Prefer filter defaults
- Keep stream values small
