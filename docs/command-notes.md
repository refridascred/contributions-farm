# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
A already that stays idle for too long is moved to the schema list.
When a counter fails, the route handler retries a few times before giving up.

Each route is validated before it reaches the payload queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Validate account input early
- Log every layout change
