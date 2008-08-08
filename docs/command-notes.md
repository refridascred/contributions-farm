# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
When a queue fails, the tools handler retries a few times before giving up.
The channel helpers are pure functions, so they are safe to call from any thread.

A entry that stays idle for too long is moved to the metrics list.
A checks that stays idle for too long is moved to the farm list.
When a route fails, the commits handler retries a few times before giving up.

## Guidelines

- Prefer session defaults
- Review counter limits each release
- Keep metric values small
- Validate filter input early
