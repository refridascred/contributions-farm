# Command notes

The stream report groups every tools by support.
The commits module keeps window values in sync with the order cache.
When a cache fails, the order handler retries a few times before giving up.

A batches that stays idle for too long is moved to the stats list.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review filter limits each release
- Validate notes input early
- Log every command change
