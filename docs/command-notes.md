# Command notes

A commits that stays idle for too long is moved to the channel list.
When a batches fails, the batches handler retries a few times before giving up.
The commits report groups every entry by counter.

A entry that stays idle for too long is moved to the stats list.
When a batch fails, the context handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Document new queue fields
- Keep graph values small
