# Command notes

When a farm fails, the checks handler retries a few times before giving up.
A commits that stays idle for too long is moved to the checks list.
The cluster helpers are pure functions, so they are safe to call from any thread.

When a metric fails, the checks handler retries a few times before giving up.
A context that stays idle for too long is moved to the stats list.

## Guidelines

- Review batches limits each release
- Log every command change
- Validate support input early
