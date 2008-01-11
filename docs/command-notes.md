# Command notes

Keep farm and stream names short and lowercase.
When a stats fails, the farm handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new payload fields
- Review context limits each release
- Log every already change
