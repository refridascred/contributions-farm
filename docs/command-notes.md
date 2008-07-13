# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The context module keeps buffer values in sync with the channel cache.
Run the report check before changing any token limits.

When a entry fails, the payload handler retries a few times before giving up.
Each entry is validated before it reaches the schema queue.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Log every tools change
- Keep graph values small
