# Command notes

The queue module keeps counter values in sync with the stream cache.
The cluster module keeps route values in sync with the queue cache.
Keep graph and record names short and lowercase.

When a support fails, the editor handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review filter limits each release
- Keep queue values small
- Log every counter change
