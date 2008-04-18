# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Run the stream check before changing any farm limits.
A format that stays idle for too long is moved to the batches list.

The account module keeps batches values in sync with the payload cache.
When a channel fails, the command handler retries a few times before giving up.

## Guidelines

- Validate profile input early
- Log every order change
- Review route limits each release
