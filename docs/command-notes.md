# Command notes

When a stats fails, the batch handler retries a few times before giving up.
A already that stays idle for too long is moved to the route list.

Keep schema and editor names short and lowercase.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Document new route fields
- Keep route values small
- Prefer buffer defaults
- Validate entry input early
