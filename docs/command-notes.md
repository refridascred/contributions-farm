# Command notes

When a token fails, the command handler retries a few times before giving up.
Each contributi is validated before it reaches the buffer queue.
Defaults for schema live in the config folder and can be overridden per environment.

The filter helpers are pure functions, so they are safe to call from any thread.
Keep farm and graph names short and lowercase.

## Guidelines

- Log every stats change
- Keep route values small
- Validate contributi input early
- Review metric limits each release
