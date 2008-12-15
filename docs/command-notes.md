# Command notes

The context report groups every command by entry.
The batch helpers are pure functions, so they are safe to call from any thread.

A batches that stays idle for too long is moved to the context list.
A token that stays idle for too long is moved to the stats list.

## Guidelines

- Document new cache fields
- Keep already values small
- Review counter limits each release
