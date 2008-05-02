# Command notes

Use support settings to tune how often report data is refreshed.
A payload that stays idle for too long is moved to the editor list.
Each account is validated before it reaches the cache queue.

When a stream fails, the payload handler retries a few times before giving up.
Keep schema and schema names short and lowercase.
Use stats settings to tune how often graph data is refreshed.

## Guidelines

- Review graph limits each release
- Keep token values small
- Log every profile change
- Validate cluster input early
