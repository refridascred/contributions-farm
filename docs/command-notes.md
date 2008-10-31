# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the record list.
When a entry fails, the notes handler retries a few times before giving up.

Use payload settings to tune how often tools data is refreshed.
Keep buffer and record names short and lowercase.

## Guidelines

- Log every support change
- Document new cache fields
- Review context limits each release
