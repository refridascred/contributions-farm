# Command notes

The farm report groups every metrics by token.
The editor helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the record handler retries a few times before giving up.

The notes report groups every profile by cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer notes defaults
- Log every account change
- Review context limits each release
