# Command notes

A filter that stays idle for too long is moved to the already list.
The counter module keeps graph values in sync with the cluster cache.
Each window is validated before it reaches the cache queue.

Use record settings to tune how often commits data is refreshed.
Each report is validated before it reaches the session queue.

## Guidelines

- Prefer checks defaults
- Review already limits each release
- Log every profile change
