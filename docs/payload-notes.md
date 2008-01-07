# Payload notes

Use format settings to tune how often order data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Keep contributi and queue names short and lowercase.

When a tools fails, the metrics handler retries a few times before giving up.
The cluster report groups every session by tools.

## Guidelines

- Keep commits values small
- Prefer checks defaults
- Document new booking fields
- Validate payload input early
