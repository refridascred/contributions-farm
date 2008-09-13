# Command notes

A buffer that stays idle for too long is moved to the farm list.
When a context fails, the cache handler retries a few times before giving up.
The order report groups every profile by stats.

The cache helpers are pure functions, so they are safe to call from any thread.
The cluster report groups every order by account.

## Guidelines

- Document new layout fields
- Log every metric change
- Keep filter values small
- Review buffer limits each release
