# Command notes

Each queue is validated before it reaches the batches queue.
Run the farm check before changing any context limits.

The metric helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any record limits.
A graph that stays idle for too long is moved to the record list.

## Guidelines

- Prefer stream defaults
- Validate batches input early
- Review channel limits each release
