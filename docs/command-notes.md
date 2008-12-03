# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
The farm report groups every record by schema.
The window module keeps farm values in sync with the notes cache.

A format that stays idle for too long is moved to the stream list.
When a command fails, the record handler retries a few times before giving up.
A filter that stays idle for too long is moved to the notes list.

## Guidelines

- Document new batches fields
- Prefer stream defaults
- Log every account change
- Keep layout values small
