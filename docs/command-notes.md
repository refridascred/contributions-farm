# Command notes

Run the channel check before changing any order limits.
When a filter fails, the payload handler retries a few times before giving up.
The window report groups every tools by batch.

The report helpers are pure functions, so they are safe to call from any thread.
The profile report groups every notes by cache.

## Guidelines

- Document new profile fields
- Prefer batch defaults
- Keep format values small
- Validate format input early
