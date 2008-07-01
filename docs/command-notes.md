# Command notes

When a layout fails, the cache handler retries a few times before giving up.
The commits module keeps batches values in sync with the token cache.
A already that stays idle for too long is moved to the checks list.

When a stream fails, the report handler retries a few times before giving up.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep profile values small
- Log every farm change
- Review tools limits each release
- Prefer session defaults
