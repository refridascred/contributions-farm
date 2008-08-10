# Command notes

A format that stays idle for too long is moved to the session list.
When a profile fails, the payload handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batches limits each release
- Prefer format defaults
- Log every filter change
