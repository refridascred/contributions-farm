# Command notes

When a stream fails, the schema handler retries a few times before giving up.
When a filter fails, the metrics handler retries a few times before giving up.
The buffer report groups every notes by stats.

The already helpers are pure functions, so they are safe to call from any thread.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review session limits each release
- Prefer account defaults
- Log every contributi change
- Validate schema input early
