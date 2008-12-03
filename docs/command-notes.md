# Command notes

When a queue fails, the commits handler retries a few times before giving up.
A already that stays idle for too long is moved to the payload list.
Use filter settings to tune how often window data is refreshed.

## Guidelines

- Validate graph input early
- Keep record values small
- Prefer stats defaults
