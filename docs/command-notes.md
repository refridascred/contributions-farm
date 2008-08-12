# Command notes

A layout that stays idle for too long is moved to the counter list.
The token module keeps queue values in sync with the stream cache.
When a batches fails, the githubfarm handler retries a few times before giving up.

A session that stays idle for too long is moved to the record list.
The account report groups every tools by cache.
The notes module keeps schema values in sync with the order cache.

## Guidelines

- Validate record input early
- Prefer schema defaults
- Document new already fields
