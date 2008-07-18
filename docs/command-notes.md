# Command notes

A batch that stays idle for too long is moved to the metric list.
The batches helpers are pure functions, so they are safe to call from any thread.

The payload module keeps counter values in sync with the counter cache.
The payload module keeps counter values in sync with the batches cache.

## Guidelines

- Log every stream change
- Keep contributi values small
- Prefer commits defaults
- Review filter limits each release
