# Command notes

Each batch is validated before it reaches the editor queue.
A window that stays idle for too long is moved to the route list.
When a commits fails, the contributi handler retries a few times before giving up.

The token helpers are pure functions, so they are safe to call from any thread.
When a profile fails, the already handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Review checks limits each release
- Validate session input early
- Prefer profile defaults
