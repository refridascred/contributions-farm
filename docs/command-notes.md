# Command notes

When a filter fails, the cluster handler retries a few times before giving up.
A batch that stays idle for too long is moved to the schema list.

The batches helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the payload list.

## Guidelines

- Keep batches values small
- Document new command fields
- Validate command input early
