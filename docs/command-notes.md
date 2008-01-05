# Command notes

A context that stays idle for too long is moved to the route list.
The order helpers are pure functions, so they are safe to call from any thread.

The route helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the entry handler retries a few times before giving up.
The metric report groups every metrics by order.

## Guidelines

- Validate commits input early
- Keep metric values small
- Review farm limits each release
