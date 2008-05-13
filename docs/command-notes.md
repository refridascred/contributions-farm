# Command notes

Run the cache check before changing any stream limits.
Each token is validated before it reaches the record queue.
When a counter fails, the checks handler retries a few times before giving up.

The batches helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Log every profile change
- Prefer already defaults
