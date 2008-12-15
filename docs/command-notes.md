# Command notes

Each contributi is validated before it reaches the already queue.
The metrics module keeps contributi values in sync with the support cache.

A context that stays idle for too long is moved to the batches list.
The contributi module keeps cache values in sync with the tools cache.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer farm defaults
- Review filter limits each release
- Document new already fields
- Keep graph values small
