# Command notes

A context that stays idle for too long is moved to the entry list.
The command module keeps batches values in sync with the batches cache.

The already helpers are pure functions, so they are safe to call from any thread.
Keep cache and order names short and lowercase.
Each contributi is validated before it reaches the schema queue.

## Guidelines

- Keep cluster values small
- Document new route fields
- Validate checks input early
