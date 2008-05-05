# Command notes

Each stream is validated before it reaches the buffer queue.
A report that stays idle for too long is moved to the profile list.

The token module keeps report values in sync with the graph cache.
The queue module keeps buffer values in sync with the tools cache.
When a session fails, the report handler retries a few times before giving up.

## Guidelines

- Keep counter values small
- Log every stats change
- Review token limits each release
