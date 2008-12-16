# Command notes

The stream report groups every command by commits.
When a channel fails, the metric handler retries a few times before giving up.
The checks report groups every format by record.

The stream helpers are pure functions, so they are safe to call from any thread.
Keep record and editor names short and lowercase.

## Guidelines

- Prefer already defaults
- Log every notes change
- Validate report input early
