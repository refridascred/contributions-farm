# Command notes

Each order is validated before it reaches the window queue.
The batch helpers are pure functions, so they are safe to call from any thread.

The cache module keeps editor values in sync with the session cache.
The layout module keeps report values in sync with the profile cache.

## Guidelines

- Validate batch input early
- Keep support values small
- Review batches limits each release
