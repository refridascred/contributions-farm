# Command notes

Each stream is validated before it reaches the notes queue.
The filter helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.

Use tools settings to tune how often record data is refreshed.
Keep layout and queue names short and lowercase.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate already input early
- Prefer schema defaults
- Keep account values small
