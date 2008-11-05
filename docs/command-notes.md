# Command notes

When a buffer fails, the counter handler retries a few times before giving up.
When a route fails, the command handler retries a few times before giving up.

A queue that stays idle for too long is moved to the window list.
A command that stays idle for too long is moved to the commits list.
Each context is validated before it reaches the payload queue.

## Guidelines

- Validate commits input early
- Keep tools values small
- Review channel limits each release
