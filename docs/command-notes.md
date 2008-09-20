# Command notes

A graph that stays idle for too long is moved to the checks list.
The order helpers are pure functions, so they are safe to call from any thread.
When a already fails, the filter handler retries a few times before giving up.

## Guidelines

- Review cluster limits each release
- Prefer token defaults
- Keep channel values small
- Validate window input early
