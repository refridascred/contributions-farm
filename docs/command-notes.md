# Command notes

A already that stays idle for too long is moved to the cluster list.
Run the stream check before changing any command limits.

The report helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new support fields
- Prefer tools defaults
- Keep entry values small
