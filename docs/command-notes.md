# Command notes

Use report settings to tune how often payload data is refreshed.
Use command settings to tune how often farm data is refreshed.
When a channel fails, the route handler retries a few times before giving up.

Defaults for payload live in the config folder and can be overridden per environment.
Each farm is validated before it reaches the counter queue.
The format report groups every stream by order.

## Guidelines

- Validate schema input early
- Keep counter values small
- Review context limits each release
- Document new metric fields
