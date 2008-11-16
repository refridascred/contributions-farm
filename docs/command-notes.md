# Command notes

A payload that stays idle for too long is moved to the queue list.
The profile module keeps route values in sync with the context cache.
The counter helpers are pure functions, so they are safe to call from any thread.

Each buffer is validated before it reaches the channel queue.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new schema fields
- Prefer farm defaults
- Review route limits each release
