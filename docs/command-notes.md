# Command notes

A queue that stays idle for too long is moved to the entry list.
The filter module keeps entry values in sync with the buffer cache.
A batch that stays idle for too long is moved to the record list.

## Guidelines

- Keep schema values small
- Review batches limits each release
- Document new support fields
