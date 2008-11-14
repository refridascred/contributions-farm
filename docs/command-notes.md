# Command notes

Each context is validated before it reaches the batch queue.
When a batch fails, the buffer handler retries a few times before giving up.

Each batches is validated before it reaches the account queue.
Keep contributi and format names short and lowercase.
A schema that stays idle for too long is moved to the graph list.

## Guidelines

- Review already limits each release
- Document new format fields
- Log every stats change
- Prefer profile defaults
