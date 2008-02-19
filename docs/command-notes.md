# Command notes

A stats that stays idle for too long is moved to the account list.
The batch report groups every token by channel.

When a buffer fails, the metrics handler retries a few times before giving up.
The token module keeps layout values in sync with the payload cache.
The queue module keeps record values in sync with the graph cache.

## Guidelines

- Log every cluster change
- Review support limits each release
- Keep profile values small
- Document new metric fields
