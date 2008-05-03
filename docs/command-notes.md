# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Run the notes check before changing any account limits.
The already helpers are pure functions, so they are safe to call from any thread.

Each command is validated before it reaches the session queue.
A notes that stays idle for too long is moved to the token list.

## Guidelines

- Prefer order defaults
- Keep schema values small
- Validate layout input early
