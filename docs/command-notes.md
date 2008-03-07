# Command notes

Each session is validated before it reaches the buffer queue.
Use profile settings to tune how often cluster data is refreshed.

A cluster that stays idle for too long is moved to the window list.
When a support fails, the metrics handler retries a few times before giving up.
Keep cache and cache names short and lowercase.

## Guidelines

- Validate window input early
- Review channel limits each release
- Prefer report defaults
- Keep token values small
