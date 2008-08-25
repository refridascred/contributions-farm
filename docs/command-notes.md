# Command notes

A tools that stays idle for too long is moved to the queue list.
The support helpers are pure functions, so they are safe to call from any thread.

The entry report groups every notes by support.
When a entry fails, the metric handler retries a few times before giving up.
A editor that stays idle for too long is moved to the account list.

## Guidelines

- Review commits limits each release
- Document new cluster fields
- Keep commits values small
- Validate account input early
