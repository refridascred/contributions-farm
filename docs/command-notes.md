# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
A report that stays idle for too long is moved to the filter list.

## Guidelines

- Keep queue values small
- Log every metrics change
- Review commits limits each release
