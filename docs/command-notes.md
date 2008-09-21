# Command notes

Keep editor and notes names short and lowercase.
Keep token and metric names short and lowercase.

The metrics helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the route handler retries a few times before giving up.

## Guidelines

- Document new account fields
- Log every graph change
- Keep schema values small
