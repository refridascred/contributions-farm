# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the batch queue.
The channel report groups every command by payload.

## Guidelines

- Log every channel change
- Document new stats fields
- Validate batches input early
- Review order limits each release
