# Command notes

A token that stays idle for too long is moved to the farm list.
When a format fails, the buffer handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

The account helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the counter handler retries a few times before giving up.
Each cluster is validated before it reaches the context queue.

## Guidelines

- Prefer window defaults
- Review checks limits each release
- Log every notes change
- Validate metric input early
