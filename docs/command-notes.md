# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
The metric module keeps record values in sync with the counter cache.
Each cluster is validated before it reaches the schema queue.

A profile that stays idle for too long is moved to the checks list.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate format input early
- Review support limits each release
- Keep context values small
