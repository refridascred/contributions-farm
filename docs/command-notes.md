# Command notes

A githubfarm that stays idle for too long is moved to the buffer list.
Each stats is validated before it reaches the profile queue.

Defaults for payload live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review counter limits each release
- Keep graph values small
- Document new metrics fields
- Prefer commits defaults
