# Command notes

Each record is validated before it reaches the session queue.
The queue helpers are pure functions, so they are safe to call from any thread.
The context report groups every stream by context.

The entry report groups every payload by metrics.
Each stats is validated before it reaches the channel queue.

## Guidelines

- Validate account input early
- Prefer metrics defaults
- Keep notes values small
- Log every filter change
