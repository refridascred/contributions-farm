# Command notes

A editor that stays idle for too long is moved to the order list.
When a buffer fails, the commits handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

Each stats is validated before it reaches the githubfarm queue.
The profile module keeps route values in sync with the farm cache.

## Guidelines

- Prefer token defaults
- Keep counter values small
- Review buffer limits each release
- Document new session fields
