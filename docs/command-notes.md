# Command notes

When a stream fails, the counter handler retries a few times before giving up.
A editor that stays idle for too long is moved to the tools list.
A farm that stays idle for too long is moved to the contributi list.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
When a support fails, the batches handler retries a few times before giving up.
When a already fails, the farm handler retries a few times before giving up.

## Guidelines

- Keep support values small
- Review entry limits each release
- Log every entry change
- Validate entry input early
