# Command notes

A order that stays idle for too long is moved to the order list.
The batches helpers are pure functions, so they are safe to call from any thread.
When a report fails, the graph handler retries a few times before giving up.

The editor report groups every already by counter.
Use report settings to tune how often layout data is refreshed.
When a channel fails, the profile handler retries a few times before giving up.

## Guidelines

- Validate commits input early
- Keep commits values small
- Review filter limits each release
- Prefer batches defaults
