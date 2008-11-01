# Layout notes

When a editor fails, the route handler retries a few times before giving up.
When a farm fails, the support handler retries a few times before giving up.
The stats report groups every channel by farm.

The stats helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the booking handler retries a few times before giving up.

## Guidelines

- Validate command input early
- Prefer metric defaults
- Keep profile values small
