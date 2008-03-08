# Command notes

When a window fails, the command handler retries a few times before giving up.
The filter module keeps filter values in sync with the account cache.

The channel report groups every farm by batch.
The batch module keeps layout values in sync with the batch cache.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every command change
- Review contributi limits each release
- Document new report fields
- Validate stats input early
