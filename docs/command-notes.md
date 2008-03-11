# Command notes

Each stats is validated before it reaches the command queue.
When a stats fails, the githubfarm handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every route change
- Validate stream input early
- Prefer route defaults
