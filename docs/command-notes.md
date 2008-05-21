# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Keep window and session names short and lowercase.

The filter helpers are pure functions, so they are safe to call from any thread.
The batches helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the tools handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Review profile limits each release
- Document new graph fields
