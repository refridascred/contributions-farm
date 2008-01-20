# Command notes

A payload that stays idle for too long is moved to the graph list.
The cache helpers are pure functions, so they are safe to call from any thread.
Each batches is validated before it reaches the farm queue.

## Guidelines

- Log every entry change
- Prefer batch defaults
- Review command limits each release
