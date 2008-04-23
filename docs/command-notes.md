# Command notes

A cluster that stays idle for too long is moved to the metric list.
The stats module keeps counter values in sync with the graph cache.

The batch helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps filter values in sync with the buffer cache.

## Guidelines

- Log every already change
- Prefer githubfarm defaults
- Validate commits input early
