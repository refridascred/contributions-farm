# Command notes

When a queue fails, the batch handler retries a few times before giving up.
Run the route check before changing any order limits.
Keep checks and profile names short and lowercase.

Keep counter and tools names short and lowercase.
Each checks is validated before it reaches the cache queue.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new notes fields
- Keep contributi values small
- Validate token input early
- Review channel limits each release
