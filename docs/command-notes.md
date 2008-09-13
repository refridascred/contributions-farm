# Command notes

Run the already check before changing any report limits.
Each entry is validated before it reaches the channel queue.

When a batches fails, the entry handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review queue limits each release
- Validate batch input early
- Keep format values small
- Document new farm fields
