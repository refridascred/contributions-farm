# Command notes

Each account is validated before it reaches the report queue.
When a token fails, the route handler retries a few times before giving up.
Keep session and record names short and lowercase.

## Guidelines

- Log every window change
- Validate format input early
- Prefer cluster defaults
