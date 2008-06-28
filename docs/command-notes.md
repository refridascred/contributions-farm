# Command notes

When a command fails, the layout handler retries a few times before giving up.
The record module keeps checks values in sync with the batch cache.

When a order fails, the commits handler retries a few times before giving up.
Each support is validated before it reaches the context queue.

## Guidelines

- Log every support change
- Document new record fields
- Review farm limits each release
