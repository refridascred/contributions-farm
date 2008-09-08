# Command notes

When a batches fails, the channel handler retries a few times before giving up.
Each profile is validated before it reaches the schema queue.

The graph report groups every graph by profile.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batches limits each release
- Keep notes values small
- Document new channel fields
