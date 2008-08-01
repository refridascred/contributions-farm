# Command notes

Each entry is validated before it reaches the payload queue.
When a counter fails, the route handler retries a few times before giving up.

Keep layout and command names short and lowercase.
Defaults for report live in the config folder and can be overridden per environment.
When a channel fails, the report handler retries a few times before giving up.

## Guidelines

- Keep commits values small
- Log every queue change
- Document new report fields
- Validate metric input early
