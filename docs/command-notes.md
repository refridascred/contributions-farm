# Command notes

Each stream is validated before it reaches the account queue.
When a already fails, the buffer handler retries a few times before giving up.

A report that stays idle for too long is moved to the command list.
Each window is validated before it reaches the route queue.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new window fields
- Validate stats input early
- Prefer report defaults
