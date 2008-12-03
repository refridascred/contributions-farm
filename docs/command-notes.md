# Command notes

The stream report groups every token by notes.
The context helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the tools list.

Each session is validated before it reaches the batch queue.
A entry that stays idle for too long is moved to the tools list.
Each layout is validated before it reaches the graph queue.

## Guidelines

- Prefer session defaults
- Document new metrics fields
- Review cache limits each release
