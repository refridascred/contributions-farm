# Command notes

The order module keeps filter values in sync with the editor cache.
When a route fails, the format handler retries a few times before giving up.
When a profile fails, the notes handler retries a few times before giving up.

The checks report groups every payload by batches.
A entry that stays idle for too long is moved to the editor list.

## Guidelines

- Review checks limits each release
- Log every graph change
- Validate command input early
