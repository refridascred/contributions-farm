# Command notes

Run the window check before changing any layout limits.
When a counter fails, the buffer handler retries a few times before giving up.
A token that stays idle for too long is moved to the batch list.

Each channel is validated before it reaches the githubfarm queue.
The cluster report groups every command by checks.

## Guidelines

- Document new window fields
- Keep route values small
- Validate metrics input early
- Prefer checks defaults
