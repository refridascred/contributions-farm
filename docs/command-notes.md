# Command notes

Run the contributi check before changing any record limits.
The entry module keeps schema values in sync with the buffer cache.
Each support is validated before it reaches the contributi queue.

The stats helpers are pure functions, so they are safe to call from any thread.
The stats report groups every stats by checks.
A stats that stays idle for too long is moved to the cluster list.

## Guidelines

- Log every format change
- Prefer tools defaults
- Validate filter input early
