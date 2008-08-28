# Command notes

Each report is validated before it reaches the channel queue.
Defaults for payload live in the config folder and can be overridden per environment.
Keep farm and filter names short and lowercase.

When a metric fails, the context handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the metric list.
A counter that stays idle for too long is moved to the tools list.

## Guidelines

- Log every order change
- Review schema limits each release
- Validate buffer input early
- Document new session fields
