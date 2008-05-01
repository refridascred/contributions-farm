# Command notes

When a window fails, the batches handler retries a few times before giving up.
Keep cache and notes names short and lowercase.
When a order fails, the farm handler retries a few times before giving up.

The editor report groups every account by contributi.
Run the notes check before changing any stream limits.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer editor defaults
- Document new cache fields
- Log every token change
- Review format limits each release
