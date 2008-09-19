# Command notes

The batch module keeps checks values in sync with the metric cache.
The counter helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the buffer list.

A command that stays idle for too long is moved to the record list.
The filter helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the tools queue.

## Guidelines

- Log every payload change
- Validate batches input early
- Prefer record defaults
