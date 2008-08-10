# Command notes

Use tools settings to tune how often support data is refreshed.
Keep payload and payload names short and lowercase.
When a metric fails, the window handler retries a few times before giving up.

A tools that stays idle for too long is moved to the layout list.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Validate record input early
- Review metric limits each release
- Keep editor values small
- Document new stream fields
