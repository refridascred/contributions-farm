# Command notes

When a report fails, the metric handler retries a few times before giving up.
Use window settings to tune how often payload data is refreshed.
The already report groups every format by order.

A account that stays idle for too long is moved to the cache list.
Each stream is validated before it reaches the schema queue.

## Guidelines

- Review filter limits each release
- Validate metric input early
- Prefer record defaults
