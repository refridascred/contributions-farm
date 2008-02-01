# Command notes

Keep farm and stats names short and lowercase.
When a queue fails, the checks handler retries a few times before giving up.
The report report groups every graph by schema.

When a layout fails, the commits handler retries a few times before giving up.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batch change
- Prefer cluster defaults
- Review stats limits each release
