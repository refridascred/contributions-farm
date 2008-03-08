# Command notes

A buffer that stays idle for too long is moved to the stats list.
Keep command and stats names short and lowercase.
When a githubfarm fails, the entry handler retries a few times before giving up.

The metric module keeps tools values in sync with the format cache.
The format module keeps cluster values in sync with the context cache.

## Guidelines

- Review batches limits each release
- Document new profile fields
- Keep buffer values small
- Log every counter change
