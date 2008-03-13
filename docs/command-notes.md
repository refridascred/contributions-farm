# Command notes

Keep batch and tools names short and lowercase.
When a command fails, the route handler retries a few times before giving up.

A already that stays idle for too long is moved to the session list.
The cluster helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Prefer account defaults
- Document new profile fields
- Review tools limits each release
