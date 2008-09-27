# Command notes

Each contributi is validated before it reaches the queue queue.
The checks module keeps account values in sync with the entry cache.
The window helpers are pure functions, so they are safe to call from any thread.

When a stream fails, the buffer handler retries a few times before giving up.
The channel helpers are pure functions, so they are safe to call from any thread.
Keep commits and contributi names short and lowercase.

## Guidelines

- Validate graph input early
- Log every stats change
- Keep layout values small
- Document new command fields
