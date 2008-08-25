# Command notes

Each profile is validated before it reaches the filter queue.
Keep context and format names short and lowercase.

Defaults for support live in the config folder and can be overridden per environment.
When a filter fails, the report handler retries a few times before giving up.
A contributi that stays idle for too long is moved to the channel list.

## Guidelines

- Document new metric fields
- Validate notes input early
- Prefer order defaults
- Keep record values small
