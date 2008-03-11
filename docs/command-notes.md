# Command notes

When a tools fails, the session handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.
The order module keeps record values in sync with the notes cache.

The profile report groups every batches by window.
The batches helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the record list.

## Guidelines

- Validate counter input early
- Prefer context defaults
- Document new token fields
