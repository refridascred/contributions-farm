# Command notes

The session module keeps format values in sync with the window cache.
When a contributi fails, the payload handler retries a few times before giving up.
When a profile fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Keep command values small
- Review batches limits each release
