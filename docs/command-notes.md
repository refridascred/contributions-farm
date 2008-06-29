# Command notes

Each queue is validated before it reaches the graph queue.
Each checks is validated before it reaches the order queue.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every graph change
- Review support limits each release
- Prefer notes defaults
