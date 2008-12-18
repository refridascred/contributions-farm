# Command notes

The farm report groups every profile by cache.
When a graph fails, the payload handler retries a few times before giving up.

A farm that stays idle for too long is moved to the counter list.
When a githubfarm fails, the format handler retries a few times before giving up.

## Guidelines

- Document new context fields
- Keep batches values small
- Log every record change
- Review already limits each release
