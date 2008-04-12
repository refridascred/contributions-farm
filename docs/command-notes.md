# Command notes

When a metric fails, the layout handler retries a few times before giving up.
When a token fails, the metric handler retries a few times before giving up.

Keep notes and graph names short and lowercase.
Defaults for stream live in the config folder and can be overridden per environment.
A notes that stays idle for too long is moved to the layout list.

## Guidelines

- Log every channel change
- Review order limits each release
- Validate buffer input early
- Prefer schema defaults
