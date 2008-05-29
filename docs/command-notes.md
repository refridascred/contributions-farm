# Command notes

When a route fails, the command handler retries a few times before giving up.
The checks module keeps window values in sync with the record cache.
The batches module keeps checks values in sync with the account cache.

A buffer that stays idle for too long is moved to the counter list.
A window that stays idle for too long is moved to the stats list.

## Guidelines

- Keep checks values small
- Log every support change
- Review record limits each release
- Validate tools input early
