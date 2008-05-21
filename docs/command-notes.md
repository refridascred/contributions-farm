# Command notes

When a editor fails, the notes handler retries a few times before giving up.
A window that stays idle for too long is moved to the editor list.

A payload that stays idle for too long is moved to the stats list.
The channel helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any route limits.

## Guidelines

- Validate graph input early
- Log every channel change
- Prefer metrics defaults
- Document new metric fields
