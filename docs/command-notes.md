# Command notes

A checks that stays idle for too long is moved to the already list.
Keep notes and stream names short and lowercase.
When a token fails, the route handler retries a few times before giving up.

Each report is validated before it reaches the channel queue.
Use route settings to tune how often buffer data is refreshed.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Review support limits each release
- Validate record input early
- Keep notes values small
