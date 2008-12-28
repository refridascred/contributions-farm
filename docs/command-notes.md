# Command notes

A queue that stays idle for too long is moved to the session list.
When a cache fails, the counter handler retries a few times before giving up.
When a contributi fails, the checks handler retries a few times before giving up.

The account helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any farm limits.

## Guidelines

- Review counter limits each release
- Log every already change
- Document new stream fields
