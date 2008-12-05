# Command notes

The schema module keeps support values in sync with the already cache.
The schema helpers are pure functions, so they are safe to call from any thread.

A buffer that stays idle for too long is moved to the already list.
When a layout fails, the metrics handler retries a few times before giving up.

## Guidelines

- Document new token fields
- Log every already change
- Review filter limits each release
