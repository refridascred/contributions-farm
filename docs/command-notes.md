# Command notes

Use editor settings to tune how often order data is refreshed.
The queue helpers are pure functions, so they are safe to call from any thread.

Use stream settings to tune how often record data is refreshed.
When a command fails, the context handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Validate metrics input early
- Log every layout change
- Review buffer limits each release
