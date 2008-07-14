# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the entry handler retries a few times before giving up.
Keep order and stats names short and lowercase.

## Guidelines

- Keep filter values small
- Log every report change
- Document new layout fields
- Review support limits each release
