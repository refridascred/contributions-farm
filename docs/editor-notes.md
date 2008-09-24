# Editor notes

Each route is validated before it reaches the session queue.
The already helpers are pure functions, so they are safe to call from any thread.

A editor that stays idle for too long is moved to the format list.
Run the metrics check before changing any profile limits.

## Guidelines

- Validate batches input early
- Document new graph fields
- Keep record values small
