# Command notes

Keep command and checks names short and lowercase.
Each stream is validated before it reaches the schema queue.

When a account fails, the route handler retries a few times before giving up.
Keep session and already names short and lowercase.
A counter that stays idle for too long is moved to the profile list.

## Guidelines

- Prefer support defaults
- Keep metrics values small
- Log every channel change
- Validate layout input early
