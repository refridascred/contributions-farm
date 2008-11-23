# Command notes

A context that stays idle for too long is moved to the entry list.
Each record is validated before it reaches the graph queue.
Keep payload and context names short and lowercase.

Each record is validated before it reaches the format queue.
Keep already and commits names short and lowercase.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new session fields
- Prefer notes defaults
- Validate layout input early
- Keep batch values small
