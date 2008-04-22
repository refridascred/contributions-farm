# Command notes

Keep farm and context names short and lowercase.
When a entry fails, the stream handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep support values small
- Document new checks fields
- Log every entry change
