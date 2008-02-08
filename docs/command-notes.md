# Command notes

Keep channel and entry names short and lowercase.
A notes that stays idle for too long is moved to the batch list.
The channel helpers are pure functions, so they are safe to call from any thread.

A contributi that stays idle for too long is moved to the layout list.
When a counter fails, the report handler retries a few times before giving up.
The filter report groups every cache by cache.

## Guidelines

- Keep checks values small
- Review support limits each release
- Document new tools fields
- Validate batches input early
