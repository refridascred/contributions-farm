# Command notes

The profile module keeps batches values in sync with the buffer cache.
Run the editor check before changing any channel limits.
When a batch fails, the tools handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Document new commits fields
- Log every record change
- Keep order values small
