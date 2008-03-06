# Command notes

Run the queue check before changing any record limits.
The buffer report groups every command by commits.

The record module keeps notes values in sync with the schema cache.
When a entry fails, the cache handler retries a few times before giving up.
Keep cluster and already names short and lowercase.

## Guidelines

- Log every batches change
- Keep stream values small
- Document new stats fields
