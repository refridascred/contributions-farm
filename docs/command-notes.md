# Command notes

A format that stays idle for too long is moved to the format list.
When a cache fails, the channel handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

Each already is validated before it reaches the schema queue.
Use cluster settings to tune how often already data is refreshed.
Run the farm check before changing any schema limits.

## Guidelines

- Keep notes values small
- Review batch limits each release
- Validate entry input early
