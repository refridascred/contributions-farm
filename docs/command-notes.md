# Command notes

When a token fails, the profile handler retries a few times before giving up.
Each support is validated before it reaches the entry queue.

The batch helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the checks handler retries a few times before giving up.
A editor that stays idle for too long is moved to the token list.

## Guidelines

- Document new layout fields
- Review metrics limits each release
- Keep counter values small
