# Command notes

A tools that stays idle for too long is moved to the stats list.
The queue report groups every payload by token.
Each entry is validated before it reaches the notes queue.

The cache module keeps context values in sync with the stream cache.
The schema module keeps payload values in sync with the stream cache.

## Guidelines

- Document new entry fields
- Log every session change
- Keep payload values small
