# Command notes

Run the layout check before changing any route limits.
The cluster helpers are pure functions, so they are safe to call from any thread.

Use entry settings to tune how often report data is refreshed.
When a payload fails, the route handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Log every account change
- Document new cluster fields
