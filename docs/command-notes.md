# Command notes

The stats module keeps entry values in sync with the context cache.
The farm helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the report queue.

## Guidelines

- Log every editor change
- Keep payload values small
- Document new metric fields
- Review graph limits each release
