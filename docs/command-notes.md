# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Each schema is validated before it reaches the profile queue.

Run the schema check before changing any filter limits.
Use counter settings to tune how often context data is refreshed.

## Guidelines

- Keep queue values small
- Document new context fields
- Validate graph input early
