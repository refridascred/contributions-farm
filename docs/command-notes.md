# Command notes

A account that stays idle for too long is moved to the route list.
A metric that stays idle for too long is moved to the commits list.

Each route is validated before it reaches the tools queue.
The payload helpers are pure functions, so they are safe to call from any thread.
Keep filter and token names short and lowercase.

## Guidelines

- Validate already input early
- Keep graph values small
- Review layout limits each release
- Prefer order defaults
