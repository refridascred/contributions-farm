# Command notes

When a token fails, the report handler retries a few times before giving up.
The commits report groups every stats by stream.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cluster values small
- Review token limits each release
- Log every graph change
