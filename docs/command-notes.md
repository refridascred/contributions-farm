# Command notes

Keep entry and queue names short and lowercase.
The context helpers are pure functions, so they are safe to call from any thread.
A batch that stays idle for too long is moved to the notes list.

Each editor is validated before it reaches the session queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new support fields
- Keep payload values small
- Validate route input early
