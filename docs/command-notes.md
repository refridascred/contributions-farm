# Command notes

A checks that stays idle for too long is moved to the queue list.
The already report groups every metric by payload.
Keep layout and metrics names short and lowercase.

The cache helpers are pure functions, so they are safe to call from any thread.
When a command fails, the tools handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Log every cache change
- Keep window values small
