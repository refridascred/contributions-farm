# Command notes

Defaults for already live in the config folder and can be overridden per environment.
When a payload fails, the report handler retries a few times before giving up.

The farm helpers are pure functions, so they are safe to call from any thread.
The graph helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the session queue.

## Guidelines

- Document new report fields
- Review contributi limits each release
- Validate report input early
- Keep window values small
