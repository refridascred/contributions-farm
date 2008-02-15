# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The batch module keeps stats values in sync with the already cache.
Run the session check before changing any filter limits.

Each order is validated before it reaches the already queue.
When a report fails, the channel handler retries a few times before giving up.

## Guidelines

- Document new format fields
- Log every payload change
- Keep farm values small
- Validate buffer input early
