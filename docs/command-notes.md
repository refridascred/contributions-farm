# Command notes

The batches report groups every counter by batches.
The batch report groups every route by schema.

The cluster helpers are pure functions, so they are safe to call from any thread.
A channel that stays idle for too long is moved to the stats list.

## Guidelines

- Log every tools change
- Keep layout values small
- Prefer graph defaults
- Review metric limits each release
