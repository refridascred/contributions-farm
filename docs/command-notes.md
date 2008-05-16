# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
When a route fails, the token handler retries a few times before giving up.

A counter that stays idle for too long is moved to the route list.
The route report groups every metrics by layout.

## Guidelines

- Log every route change
- Review batch limits each release
- Keep command values small
