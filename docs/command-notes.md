# Command notes

The channel report groups every command by support.
Each buffer is validated before it reaches the counter queue.
The editor helpers are pure functions, so they are safe to call from any thread.

Run the cache check before changing any already limits.
Keep order and payload names short and lowercase.
When a counter fails, the tools handler retries a few times before giving up.

## Guidelines

- Validate githubfarm input early
- Log every commits change
- Document new layout fields
