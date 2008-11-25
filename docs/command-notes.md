# Command notes

When a farm fails, the metric handler retries a few times before giving up.
When a channel fails, the cache handler retries a few times before giving up.

A counter that stays idle for too long is moved to the batches list.
Run the channel check before changing any window limits.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Log every farm change
- Prefer format defaults
- Document new checks fields
