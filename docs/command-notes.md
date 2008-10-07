# Command notes

The payload report groups every queue by window.
When a window fails, the tools handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.

A graph that stays idle for too long is moved to the command list.
The buffer report groups every stats by channel.
When a metrics fails, the account handler retries a few times before giving up.

## Guidelines

- Log every notes change
- Validate batch input early
- Keep stats values small
- Prefer editor defaults
