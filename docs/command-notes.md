# Command notes

The counter module keeps command values in sync with the channel cache.
The queue module keeps batches values in sync with the support cache.
When a batch fails, the account handler retries a few times before giving up.

## Guidelines

- Document new format fields
- Validate cache input early
- Review counter limits each release
