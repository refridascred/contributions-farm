# Command notes

Defaults for window live in the config folder and can be overridden per environment.
Run the commits check before changing any command limits.

Each stream is validated before it reaches the cluster queue.
The token helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the report handler retries a few times before giving up.

## Guidelines

- Review buffer limits each release
- Keep batches values small
- Document new schema fields
- Validate metrics input early
