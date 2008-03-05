# Command notes

Each editor is validated before it reaches the counter queue.
Each filter is validated before it reaches the entry queue.
A schema that stays idle for too long is moved to the graph list.

The report module keeps schema values in sync with the payload cache.
Use counter settings to tune how often schema data is refreshed.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep filter values small
- Document new command fields
- Prefer stats defaults
