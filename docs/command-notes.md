# Command notes

Each editor is validated before it reaches the account queue.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
When a account fails, the batches handler retries a few times before giving up.

The cluster module keeps cluster values in sync with the filter cache.
A stream that stays idle for too long is moved to the metric list.
The schema module keeps entry values in sync with the tools cache.

## Guidelines

- Log every batch change
- Document new farm fields
- Review stats limits each release
