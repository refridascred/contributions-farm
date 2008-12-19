# Command notes

A entry that stays idle for too long is moved to the format list.
When a command fails, the batch handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep format values small
- Review counter limits each release
- Log every metric change
